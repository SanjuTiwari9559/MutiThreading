namespace AsyncAndAwait
{
    internal class Program
    {
        static  async void  Main(string[] args)
        {
            string message= await DoWorkAsync();
            workDone();
                                                 //If U are Using await then It Must Be Async Function and It can Be Return Task Or Not 
        }                                       //This Is Async call and Wating call and Non Blocking  call
        public static async Task<String> DoWorkAsync()
        {
            return  await Task.Run(() => { Thread.Sleep(1000);return "WorkDone"; });
        }
        public static void workDone()
        {
            Console.WriteLine("This is Work Done ");
        }
    }
}
