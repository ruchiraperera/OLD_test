I'm also researching this to find out what differences are. I can come up with some idea that may help you. 
I think about the purpose they are the same, not so much different. But DelegatingHandler is old mechanism compare 
to owin.

Owin middlewares:

    The purpose of this is separating the server and the application. By doing this, you can inject a lot of modules to your pipeline(that is called owinmiddleware).
    By doing this, you can intercept the request at very early stage of httprequest before HttpMessageHandler of web api can process it. For example. you can read the data for initializing dependency before http controller is created.
    By doing modules, you can reuse the middleware that asp.net core is focusing.

DelegatingHandler:

    It is a part of web api. At this level, we have HttpRequestMessage, HttpResponseMessage, 
	so we can easily manipulate with those rather than owin middleware( for example you can read the data 
	from request message body without worrying we did something that is effecting the message)

    By doing that, actually, you are strongly depend on web api pipeline. I'm not saying that you can not 
	reuse it in the furture but it may be happened.

Hope it gives you helpful information about that.