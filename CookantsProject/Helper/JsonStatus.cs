using Newtonsoft.Json.Linq;

namespace CoockantsWeb.Helper
{
    public static class JsonStatus
    {
        public class JsonMessage
        {
            public bool Status { get; set; }
            public object Data { get; set; }
            public string Message { get; set; }
        }
        public static JObject SaveSuccess(object data)
        {
            JsonMessage jsonMessage = new JsonMessage { Status = true, Data = data, Message = "Data Saved!" };
            return JObject.FromObject(jsonMessage);
        }

        public static JObject SaveFaild()
        {
            JsonMessage jsonMessage = new JsonMessage { Status = false, Data = null, Message = "Data Saved Faild!" };
            return JObject.FromObject(jsonMessage);
        }

        public static JObject UpdateSuccess(object data)
        {
            JsonMessage jsonMessage = new JsonMessage { Status = true, Data = data, Message = "Data Updated!" };
            return JObject.FromObject(jsonMessage);
        }

        public static JObject UpdateSuccess()
        {
            JsonMessage jsonMessage = new JsonMessage { Status = true, Data = null, Message = "Paid successfuly" };
            return JObject.FromObject(jsonMessage);
        }
        public static JObject UpdateFaild()
        {
            JsonMessage jsonMessage = new JsonMessage { Status = false, Data = null, Message = "Data Updated Faild!" };
            return JObject.FromObject(jsonMessage);
        }
        public static JObject DeleteSuccess()
        {
            JsonMessage jsonMessage = new JsonMessage { Status = true, Data = null, Message = "Data Deleted!" };
            return JObject.FromObject(jsonMessage);
        }

        public static JObject DeleteFaild()
        {
            JsonMessage jsonMessage = new JsonMessage { Status = false, Data = null, Message = "Data Deleted Faild!" };
            return JObject.FromObject(jsonMessage);
        }

        public static JObject NotFound()
        {
            JsonMessage jsonMessage = new JsonMessage { Status = false, Data = null, Message = "Data Not Found!" };
            return JObject.FromObject(jsonMessage);
        }
        public static JObject DataFound(object data)
        {
            JsonMessage jsonMessage = new JsonMessage { Status = true, Data = data, Message = "Data Found Successfully!" };
            return JObject.FromObject(jsonMessage);
        }

        public static JObject CustomMessage(bool status, object data, string message)
        {
            JsonMessage jsonMessage = new JsonMessage { Status = status, Data = data, Message = message };
            return JObject.FromObject(jsonMessage);
        }
    }
}