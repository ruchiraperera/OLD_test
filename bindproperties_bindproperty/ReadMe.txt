   for post form 
   
   public class ModelBindingModel : PageModel
    {
        [BindProperty]
        public Login Login { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["welcome"] = $"Welcome {Login.Email}";
        }
    }

	for get

	 public class ModelBindingModel : PageModel
    {
        [BindProperty(SupportsGet= true )]
        public int Id { get; set; }
        public void OnGet()
        {
            ViewData["id"] = Id;
        }
        public void OnPost()
        {
                
        }
    }

	-----------------------------------------------------

	
    FromQuery - specifies that model binding should obtain values from the request query string
    FromHeader - specifies that values should be taken form the request header values
    FromBody - the values to be bound should be obtained from the request body
    FromRoute - route data should be used as the source for model binding values

	reference - https://www.learnrazorpages.com/razor-pages/model-binding
