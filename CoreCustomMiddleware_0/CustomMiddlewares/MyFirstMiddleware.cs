namespace CoreCustomMiddleware_0.CustomMiddlewares
{
    public class MyFirstMiddleware
    {
        RequestDelegate _requestDelegate;

        public MyFirstMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        //Metot isminin Invoke olmasına ve HttpContext tipinde parametre almasına dikkat ediniz...
        public async Task Invoke(HttpContext context)
        {

            int a = context.Response.StatusCode;
            if (context.Request.Path == "/Deneme")
                await context.Response.WriteAsync("Deneme path'i tespit edildi");
            else 
                await _requestDelegate.Invoke(context);
        }


        
   
    }
}
