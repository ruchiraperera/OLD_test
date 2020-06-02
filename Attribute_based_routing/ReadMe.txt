Why Attribute Routing?

For example, a socially enhanced e-commerce website could have the following routes:

    {productId:int}/{productTitle}
    Mapped to ProductsController.Show(int id)
    {username}
    Mapped to ProfilesController.Show(string username)
    {username}/catalogs/{catalogId:int}/{catalogTitle}
    Mapped to CatalogsController.Show(string username, int catalogId)


Enabling Attribute Routing
To enable attribute routing, call MapMvcAttributeRoutes during configuration.

	[Route("[Controller]")] - this will take controller name as parameter

	[RoutePrefix(“reviews”)] 
	[Route(“{action=index}”)] - set Default Route


	// eg.: /reviews/5
    [Route(“{reviewId}”)] 

	// eg.: /reviews/5/edit
    [Route(“{reviewId}/edit”)] 

	// eg.: /spotlight-review
    [Route(“~/spotlight-review”)] 

	Route Constraints
	// eg: /users/5
	[Route(“users/{id:int}”]

	[Route(“users/{id:int:range(1000:3000)}”]