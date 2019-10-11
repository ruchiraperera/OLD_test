Content-Security-Policy

<system.webServer>
  <httpProtocol>
    <customHeaders>
      <add name="Content-Security-Policy" value="default-src 'self'" />
    </customHeaders>
  </httpProtocol>
</system.webServer>


<add name="Content-Security-Policy" value="default-src 'self' https://cdnjs.cloudflare.com" />

<add name="Content-Security-Policy-Report-Only" value="default-src 'self'" />

//------------------------------------------------------------------------------------------------------

X-Frame-Options : -
The X-Frame-Options header ensure, that hackers don't iframe your site, 
in order to trick you into clicking links which you never intended to. If you are using ASP.NET MVC 5 
or newer, this header is added automatically. Adding the header in previous versions or other web frameworks 
is easy using web.config:

<system.webServer>
  <httpProtocol>
    <customHeaders>
      <add name="X-Frame-Options" value="DENY" />
    </customHeaders>
  </httpProtocol>
</system.webServer>


X-Xss-Protection : -
The X-Xss-Protection is a feature implemented in most modern browser, 
which will stop loading the page when a cross-site scripting attack is detected. 
Adding the header happens through web.config as well:

<system.webServer>
  <httpProtocol>
    <customHeaders>
      <add name="X-Xss-Protection" value="1; mode=block" />
    </customHeaders>
  </httpProtocol>
</system.webServer>


X-Content-Type-Options

To avoid MIME type sniffing, you can add the X-Content-Type-Options header. 
This makes it harder for hackers to guess the right mime type, by inspecting the content. 
Adding the header is easily done through web.config:

<system.webServer>
  <httpProtocol>
    <customHeaders>
      <add name="X-Content-Type-Options" value="nosniff" />
    </customHeaders>
  </httpProtocol>
</system.webServer>

How can I set the Secure flag on an ASP.NET Session Cookie?
<configuration>
  <system.web>
    <!-- Force secure connections for all Cookies -->
    <httpCookies requireSSL="true" />
  </system.web>
</configuration>

Strict-Transport-Security

If you haven't implemented HTTPS on your website, you should. After doing so, you can prevent any communication happening over 
HTTP using the Strict-Transport-Security header:

<system.webServer>
  <httpProtocol>
    <customHeaders>
      <add name="Strict-Transport-Security" value="max-age=31536000; includeSubDomains" />
    </customHeaders>
  </httpProtocol>
</system.webServer>