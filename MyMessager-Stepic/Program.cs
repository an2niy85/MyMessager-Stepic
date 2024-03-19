using Newtonsoft.Json;

namespace MyMessager_Stepic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializeMsg);

            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2024-03-19T07:13:40.7266465Z"}
            //RusAl < 19.03.2024 7:13:40 >: Privet

            //Console.WriteLine("Начало проекта");
            //Console.WriteLine(msg.ToString());
        }
    }
}
