using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;



namespace ApiClient
{

  class joke
  {
   public int id { get; set; } 
   public string type { get; set; }
   public string setup { get; set; }
   public string punchline { get; set; }

  }
  class Program
  {

    static async System.Threading.Tasks.Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseAsStream = await client.GetStreamAsync("https://official-joke-api.appspot.com/random_ten");

            List<joke>jokes = await JsonSerializer.DeserializeAsync<List<joke>>(responseAsStream);

            foreach (var joke in jokes)
            {
              Console.WriteLine($"Setup: {joke.setup} Punchline: {joke.punchline}....waka waka waka ");
            }



            




  

    

          




       
                  
                   
        
        
        
        

                          



      



    }
  }
}
