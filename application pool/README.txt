ASP.NET application pool memory optimization
If your ASP.NET application pool reaches the private memory bytes limit IIS will recycle it to re-initialize it and make it operational. This recycle will re-load the site and cause a loss of the temporary information and caching stored in the application pool.

Some of the most effective and common ways to prevent that are listed below:

1. Disable Dynamic caching – be default we use IIS dynamic caching feature to speed up and optimize customer web sites. The cached information is stored in the application pool memory. When disabling that function, the memory used for the cache will be removed from the application pool. PLEASE NOTE: Disabling dynamic caching can affect your site performance.

2. Disable ViewState on Labels - The ViewState is how ASP.NET keeps track of changes that have been made to Web Controls.  ViewState is needed anytime you are going to do a postback, like for a submit form.  However, a common mistake is programmers do not disable viewstate on Label controls that are often used as placeholders for long concatenated HTML strings.  If you suspect you may be guilty of this all it takes is a look at the HTML source code from your web browser to confirm it.  If your HTML source looks like this with a really big view state then you need to disable the viewstate on your label controls.  The Viewstate is stored in the W3WP.exe process.  It’s easy to see how this process can consumer so much memory when you have a view state this large and on an exponential number of web pages. The solution is to change your ASP:Label Controls from this

<asp:Label ID="mainmenu" runat="server" />

to this

<asp:Label ID="mainmenu" EnableViewState="false" runat="server" />

3. Long Session Time Outs - Anytime a visitor (organic or spider) visits your website, ASP.NET is going to maintain a session with them.  Sessions are how the server keeps track of your users and their activity on your website.  Without Sessions, things like postback would not be possible.  When ASP.NET uses sessions in the traditional way, they store a Session ID in a cookie on the client's browser.  Then every time this client communicates with the server this cookie value (Session ID) is passed along with the request.  The Server can then identify the visitor by their Session ID and handle the requests appropriately.  Now the server has to keep track of the visitors activity.  So each time a submit form is submitted, or a web control is used, the information related to this action is stored with the viewstate in the W3WP.exe, and is tied to the Session ID.  This memory is not released until the Session Expires.  The shorter your Session Time Outs, the less memory that will be needed to track your visitors as they navigate through your website.

4. Memory Leaks - Certain objects should be cleared from memory with the Dispose() Method.  These include things like BitMap Objects.  Even though the ASP.NET Garbage Collection does a good job of taking out the trash, if you do not release Bitmaps with the Dispose Method it tends to lock the image file you were working with.  This object will sit in your W3WP.exe taking up space.
 
5. Unclosed Database Connections - If you use helper functions to manage your Database connections, be sure that you close the connections, when finished or this will waste memory on both the W3WP.exe side and the Database Server side.