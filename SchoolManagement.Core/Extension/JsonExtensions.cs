using Newtonsoft.Json;

namespace SchoolManagement.Libraries.Core.Extension
{
    public static class JsonExtensions
    {
        public static string ToJson(this object value, Formatting formatting = Formatting.None)
        {
            return JsonConvert.SerializeObject(value, formatting);
        }
    }
}