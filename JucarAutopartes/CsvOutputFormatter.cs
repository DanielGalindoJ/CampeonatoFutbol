using Entities.Models;
using Entities.Models.Users;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Shared.DataTransferObjects;
using Shared.DataTransferObjects.Users;
using System.Text;

namespace APIRestProyecto
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        protected override bool CanWriteType(Type? type)
        {
            if (typeof(UserDto).IsAssignableFrom(type) ||
                typeof(IEnumerable<UserDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }
            return false;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<UserDto> users)
            {
                foreach (var user in users)
                {
                    FormatCsv(buffer, user);
                }
            }
            else if (context.Object is UserDto user)
            {
                FormatCsv(buffer, user);
            }

            await response.WriteAsync(buffer.ToString());
        }

        private static void FormatCsv(StringBuilder buffer, UserDto user)
        {
            buffer.AppendLine($"{user.LastName},\"{user.UserName}\",\"{user.Email}\"");
        }
    }
}
