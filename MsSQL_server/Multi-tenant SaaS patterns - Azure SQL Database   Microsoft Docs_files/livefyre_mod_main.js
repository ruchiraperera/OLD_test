(function(z){
var AK=function(a,b,c){b="new"===(b||a.od);return c?(a=a.d.u.v().get(z.U.Ep),b?-1:-a):a.gl+(b?-1:1)};var BK=function(a){z.Dv.call(this,a);this.gl=0;this.od="new"};var CK=function(a,b){a.ZX=b};
var DK=function(a){return(0,z.Q)('\x3cdiv class\x3d"fyre '+(a.Ld?"fyre-liveblog ":"")+(a.gh?"fyre-livechat ":"")+(a.sU?"fyre-bootstrap ":"")+(a.re?"fyre-mobile":"")+'"\x3e\x3cdiv class\x3d"fyre-widget '+(a.Ra?"fyre-avatar-disabled":"")+'"\x3e'+(0,z.Q)('\x3cdiv class\x3d"fyre-featured-content-wrapper" style\x3d"display: none"\x3e\x3c/div\x3e')+'\x3cdiv class\x3d"fyre-stream-stats"\x3e\x3cdiv class\x3d"fyre-comment-count"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-help"\x3e\x3c/div\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-auth"\x3e\x3cdiv class\x3d"fyre-login-bar"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-live-container"\x3e\x3cdiv class\x3d"fyre-livecount"\x3e\x3c/div\x3e'+
(a.Ra?"":'\x3cdiv class\x3d"fyre-listener-avatars"\x3e\x3c/div\x3e')+'\x3c/div\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-editor"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-input-box-collapsed"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-stream-header"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-comment-stream"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-top-content-stream"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-thread-breakout-stream"\x3e\x3c/div\x3e'+(a.qo?'\x3cdiv class\x3d"fyre-archive-stream-header"\x3e\x3c/div\x3e\x3cdiv class\x3d"fyre-archive-stream"\x3e\x3c/div\x3e':
"")+'\x3cdiv class\x3d"fyre-stream-menu-container"\x3e\x3c/div\x3e\x3c/div\x3e\x3c/div\x3e')};var EK=function(a){return(0,z.Q)('\x3ca href\x3d"'+z.R(z.S(a.Aa))+'" title\x3d"'+z.R(a.aa)+'" aria-label\x3d"'+z.R(a.aa)+" "+z.R(a.j.profile)+'" data-id\x3d"'+z.R(a.id)+'" class\x3d"fyre-follower fyre-follower-'+z.R(a.aU)+'"\x3e\x3cimg src\x3d"'+z.R(z.S(a.Vc))+'" alt\x3d"'+z.R(a.aa)+" "+z.R(a.j.Vc)+'" onerror\x3d"javascript:this.src\x3d\''+z.R(z.ap(a.ec))+"';\" /\x3e\x3c/a\x3e")};
var FK=function(a){return(0,z.Q)(z.$q(a)+'\x3cdiv class\x3d"fyre-archive-stream-sort fyre-stream-sort"\x3e\x3ch3 class\x3d"fyre-archive-stream-title"\x3e\x3cstrong class\x3d"fyre-archive-stream-title-icon"\x3e\x3c/strong\x3e'+z.P(a.j.HO)+'\x3c/h3\x3e\x3cdiv class\x3d"fyre-stream-sort-options"\x3e\x3ca class\x3d"fyre-stream-sort-newest fyre-stream-sort-selected"\x3e'+z.P(a.j.ey)+'\x3c/a\x3e\x3cspan class\x3d"fyre-stream-sort-bar"\x3e'+z.P(a.j.Vo)+'\x3c/span\x3e\x3ca class\x3d"fyre-stream-sort-oldest"\x3e'+
z.P(a.j.fy)+"\x3c/a\x3e\x3c/div\x3e\x3c/div\x3e")};var GK=function(a){return(0,z.Q)('\x3cdiv class\x3d"tooltip"\x3e'+z.P(a.message)+'\x3c/div\x3e\x3cdiv class\x3d"arrow-down"\x3e\x3c/div\x3e')};var HK=function(){};var IK=function(a){this.OG=!1;this.Lo=[];this.Ab=null;z.xf.call(this,a)};var JK=function(a,b){z.Cj.call(this,b,a)};var KK=function(a,b){z.aG.call(this,a,b)};
var LK=function(a,b){var c=a.d.Jb;c.th[4]&&(z.xz(c,4,(0,z.s)(function(a){b.e(a,"threadBreakout",this.Or)},a)),z.zz(c,4,(0,z.s)(function(a){b.Fa(a,"threadBreakout",this.Or)})))};
var MK=function(a,b){if(!z.lk(b,"fyre-stream-sort-selected")&&"A"===b.tagName&&b!==a.Cg)if(b===a.sl)a.LF();else{NK(a,b);a.rm();z.y(b.parentElement.children,function(a){a.setAttribute("aria-selected",a===b)});var c=null;switch(b){case a.vt:a.uE();c="hottest";break;case a.yz:a.dispatchEvent({type:"sortTopComments",Yb:(0,z.s)(a.Id,a)});c="top_comments";break;case a.sm:a.un("new");c="newest";break;case a.xz:a.un("old"),c="oldest"}a.d.Lb.send(z.Wn("SortStream",{Es:c}))}};
var NK=function(a,b){var c=[a.sm,a.xz];a.Cg&&c.push(a.Cg);a.vt&&c.push(a.vt);a.yz&&c.push(a.yz);z.y(c,function(a){z.hk(a,"fyre-stream-sort-selected")});z.fk(b,"fyre-stream-sort-selected")};var OK=function(a,b){z.aG.call(this,a,b)};var PK=function(a,b){z.Xx.call(this,a,b);this.fh=!1;this.ZI=!!this.L.J.QG;this.Ia=new z.fy;this.Ia.uc(this);this.uu="archiveShowMore"};var QK=function(a,b){z.cG.call(this,a,b)};var RK=function(a,b,c){z.fu.call(this,a,b,c);this.Tz=b||"";this.zg(GK(this.s()))};
var SK=function(a,b,c){z.$t.call(this,a,b||3,c)};var TK=function(a,b){z.T.call(this,b);this.l=a;this.zt=z.W};var UK=function(a,b){z.T.call(this,b);this.Ec=a};var VK=function(a,b){UK.call(this,a,b)};
var WK=function(){var a=z.u.window,b=z.u.document;function c(){var a=x.elements;return"string"==typeof a?a.split(" "):a}function d(a){var b={},d=a.createElement,f=a.createDocumentFragment,g=f();a.createElement=function(a){x.BX||d(a);var c;c=b[a]?b[a].cloneNode():k.test(a)?(b[a]=d(a)).cloneNode():d(a);return c.canHaveChildren&&!h.test(a)?g.appendChild(c):c};a.createDocumentFragment=Function("h,f","return function(){var n\x3df.cloneNode(),c\x3dn.createElement;h.shivMethods\x26\x26("+c().join().replace(/\w+/g,
function(a){b[a]=d(a);g.createElement(a);return'c("'+a+'")'})+");return n}")(x,g)}function f(a){var b;if(a.NP)return a;if(x.AX&&!m){b=a.createElement("p");var c=a.getElementsByTagName("head")[0]||a.documentElement;b.innerHTML="x\x3cstyle\x3earticle,aside,details,figcaption,figure,footer,header,hgroup,nav,section{display:block}audio{display:none}canvas,video{display:inline-block;*display:inline;*zoom:1}[hidden]{display:none}audio[controls]{display:inline-block;*display:inline;*zoom:1}mark{background:#FF0;color:#000}\x3c/style\x3e";
b=!!c.insertBefore(b.lastChild,c.firstChild)}r||(b=!d(a));b&&(a.NP=b);return a}var g={},h=/^<|^(?:button|form|map|select|textarea|object|iframe)$/i,k=/^<|^(?:a|b|button|code|div|fieldset|form|h1|h2|h3|h4|h5|h6|i|iframe|img|input|label|li|link|ol|option|p|param|q|script|select|span|strong|style|table|tbody|td|textarea|tfoot|th|thead|tr|ul)$/i,m,r;(function(){var c=b.createElement("a");c.innerHTML="\x3cxyz\x3e\x3c/xyz\x3e";(m="hidden"in c)&&"function"==typeof a.nU&&a.nU("#modernizr{}",function(b){b.hidden=
!0;m="none"==(a.getComputedStyle?a.getComputedStyle(b,null):b.currentStyle).display});r=1==c.childNodes.length||function(){try{b.createElement("a")}catch(a){return!0}var c=b.createDocumentFragment();return"undefined"==typeof c.cloneNode||"undefined"==typeof c.createDocumentFragment||"undefined"==typeof c.createElement}()})();var x={elements:g.elements||"abbr article aside audio bdi canvas data datalist details figcaption figure footer header hgroup mark meter nav output progress section summary time video",
shivCSS:!1!==g.AX,shivMethods:!1!==g.BX,type:"default",shivDocument:f};f(b)};var XK=function(a,b){z.mG.call(this,a,b);a.J.HP||WK();var c=a.u.Dc(),d=a.u.v();this.pi=new z.eG(a,a.Sl.ya,d.gh()||z.Xf);this.D(this.pi);a.J.Ra||(this.Fn=new VK(c),this.D(this.Fn));this.Wr=new z.dG;this.D(this.Wr)};var YK=function(a){var b=z.F.eb()||z.F.get(z.E.Gp);return!a.w.Ld()||b};var ZK=function(a){z.sG.call(this,a);this.Xm=1};
var $K=function(a){z.Ss.call(this,a);z.iv(a.u);this.Ub=new XK(a);this.Yq.start();this.Il(this.Ub);z.Xs(this)};var aL=function(a,b){this.gD=JK;this.ZJ=$K;z.W.nm(b.strings||{});z.Fn.call(this,a,b);this.Ya.Lb.send(z.Wn("Init"))};var bL=function(a){a.pk&&(a.pk.q(),delete a.pk)};z.v(BK,z.Dv);z.e=BK.prototype;z.e.tl=z.l(57);z.e.OF=z.l(59);z.e.PF=z.l(58);z.e.OF=z.L(59,function(a){this.La||(this.Ho[a]=!1,z.Ev(this,a,function(a){a.N(a.Ca.Wm)}))});
z.e.PF=z.L(58,function(a,b){if(!this.La){var c=this.d.u.v(),d=z.Su(a,b),f=c.get(z.U.Rt);c.set(z.U.Ep,d.GV);z.A(d.gb,(0,z.s)(this.d.U.N,this.d.U,"bootstrap_author_received"));d.content=z.ej(d.content,function(a,b){return!z.Ua(f,b)});z.A(d.content,function(a){z.kb(d.content,z.Gv(this,a))},this);z.kb(this.tc,z.dj(d.content,z.Bb(a)));this.ae(a,d.content);z.Ev(this,a,function(b){b.N(b.Ca.Gk,{Pd:a});b.set(b.k.qf,!0)})}});
z.e.tl=z.L(57,function(a,b){this.gl=a;this.od=b||this.od;var c=this.Qd[a]=new z.zv;z.Iu.C();var d=this.d.u.v(),f=(0,z.s)(this.PF,this,a),g=(0,z.s)(this.OF,this,a),h=this.d.J.an,d=d.get(z.U.mc),h=z.w.Zu(d,h)+String(a)+".json";z.Ju(0,h,f,g);return c});z.aw.prototype.tl=z.L(56,function(a,b){this.Sk||(this.Sk=new BK(this.L));var c=this.Sk,d=AK(c,a,b);return c.tl(d,a)});z.Iu.prototype.Wh=z.L(50,function(a,b,c){a=z.wa("%s%scollection/%s/hot/",z.w.H.Cd,z.w.lf,a.ta);(new z.Ie({url:a,ua:b,oa:c})).send()});
z.Uv.prototype.Wh=z.L(49,function(a){var b={ta:this.d.u.v().id},c=z.Iu.C().Wh;z.Vv(this,c,b,a);return a});z.aw.prototype.Wh=z.L(48,function(){z.$v(this);this.Pi=new z.Uv(this.L,void 0);var a=new z.zv;this.Pi.Wh(a);return a});z.Iu.prototype.Sh=z.L(47,function(a,b,c){a=z.wa("%s%scollection/%s/top/%s/",z.w.H.Cd,z.w.lf,a.ta,a.AO);(new z.Ie({url:a,ua:b,oa:c})).send({format:"stream"})});z.Uv.prototype.Sh=z.L(46,function(a,b){var c={ta:this.d.u.v().id,AO:a},d=z.Iu.C().Sh;z.Vv(this,d,c,b);return b});
z.aw.prototype.Sh=z.L(45,function(a){z.$v(this);this.Pi=new z.Uv(this.L,void 0);var b=new z.zv;this.Pi.Sh(a,b);return b});z.T.prototype.bH=z.L(44,function(){return this.ba});z.zj.prototype.qo=z.L(43,function(){return this.get(this.k.Dp)});z.v(HK,z.Ln);z.ca(HK);var cL={hZ:"attachmentDelegate"};z.kb(cL,z.hH);HK.prototype.no=function(a){var b=HK.b.no.call(this,a),c=a.attachmentDelegate;c&&(b.JO=c);b.Yx=a[cL.iM]||null;return b};z.v(IK,z.xf);IK.prototype.PU=function(a){this.Ab||(this.Ab=z.u.setInterval((0,z.s)(this.JQ,this),5E3));this.Lo=this.Lo.concat(a)};
IK.prototype.JQ=function(){this.Lo.length&&(this.OG||(z.dg("//platform.twitter.com/impressions.js"),this.OG=!0),z.u.twttr=function(){var a=z.u.twttr||{},b=a.impressions||{};b._e=b._e||[];b.ready=b.ready||function(a){b._e.push(a)};a.impressions=b;return a}(),z.u.twttr.impressions.ready((0,z.s)(function(a){a.impressions.logTweets(this.Lo,{partner:"livefyre"});this.Lo=[]},this)))};IK.prototype.q=function(){(0,window.clearInterval)(this.Ab);IK.b.q.call(this)};z.v(JK,z.Cj);JK.prototype.hz=function(a){this.Gu=new z.Qq(this,a);this.Lb=new z.Nn(this);this.Jc=new z.ri(this);this.u=new z.fv(this,a);this.jb=new z.rv(this,a);this.Mb=new z.aw(this,a);this.Sl=new z.fw(this);new z.hf;this.ap=new z.Gw(this,a);this.Fz=new z.gw(this);this.Ki=new z.vw(this);this.Vz=new z.Ku(this,a);this.vY=new IK(this);this.Jb=new z.nz(this)};z.v(KK,z.aG);z.e=KK.prototype;z.e.s=function(){var a={},b=this.d.u,c=b.v();a.Tx=b.v().Ld();a.DV=!z.F.get(z.F.k.Xd);a.Kd=b.Kd(z.F.id);a.KP=2===c.get(z.U.bj);a.JP=3===c.get(z.U.bj);a.j={IU:z.W.get(z.W.g.iu),LU:z.W.get(z.W.g.ju),ZT:z.W.get(z.W.g.nB),ey:z.W.get(z.W.g.Zp),fy:z.W.get(z.W.g.$p),Vo:z.W.get(z.W.g.oC),kp:z.W.get(z.W.g.dq),nY:z.W.get(z.W.g.FC)};return a};
z.e.K=function(a){KK.b.K.call(this,a);a=this.c;var b;b=this.s();var c=z.Q,d=z.$q(b),f;f=b.Tx?(0,z.Q)('\x3ca class\x3d"fyre-follow-conversation"\x3e'+(b.DV?b.Kd?z.P(b.j.LU):z.P(b.j.IU):"")+"\x3c/a\x3e"):"";b=c(d+f+'\x3cdiv class\x3d"fyre-stream-sort"\x3e\x3cdiv class\x3d"fyre-stream-sort-options"\x3e\x3ca class\x3d"fyre-stream-sort-newest fyre-stream-sort-selected" aria-selected\x3d"true" aria-label\x3d"Sort by Newest" tabindex\x3d"0"\x3e'+z.P(b.j.ey)+'\x3c/a\x3e\x3cspan class\x3d"fyre-stream-sort-bar"\x3e'+
z.P(b.j.Vo)+'\x3c/span\x3e\x3ca class\x3d"fyre-stream-sort-oldest" aria-selected\x3d"false" aria-label\x3d"Sort by Oldest" tabindex\x3d"0"\x3e'+z.P(b.j.fy)+"\x3c/a\x3e"+(b.KP?'\x3cspan class\x3d"fyre-stream-sort-bar"\x3e'+z.P(b.j.Vo)+'\x3c/span\x3e\x3ca class\x3d"fyre-stream-sort-top-comments" aria-selected\x3d"false" aria-label\x3d"Sort by Top Comments" tabindex\x3d"0"\x3e'+z.P(b.j.nY)+"\x3c/a\x3e":"")+(b.JP?'\x3cspan class\x3d"fyre-stream-sort-bar"\x3e'+z.P(b.j.Vo)+'\x3c/span\x3e\x3ca class\x3d"fyre-stream-sort-hot-threads" aria-selected\x3d"false" aria-label\x3d"Sort by Hot Threads" tabindex\x3d"0"\x3e'+
z.P(b.j.ZT)+"\x3c/a\x3e":"")+'\x3c/div\x3e\x3ca class\x3d"fyre-stream-sort-back"\x3e\x3c/a\x3e\x3c/div\x3e');a.innerHTML=b;this.sl=this.o("fyre-follow-conversation");this.vt=this.o("fyre-stream-sort-hot-threads")||null;this.yz=this.o("fyre-stream-sort-top-comments")||null;this.Cg=this.o("fyre-stream-sort-back");this.sm=this.o("fyre-stream-sort-newest");this.xz=this.o("fyre-stream-sort-oldest");this.dJ=this.o("fyre-stream-sort-options");this.dd=this.o("fyre-content-loading");this.Id()};
z.e.m=function(){KK.b.m.call(this);var a=this.p();z.F.on(z.F.Ca.Wf,this.fo,this);a.e(this.c,"click",this.lb);a.e(this.c,"keydown",this.uS);z.y([3,4,5],function(b){z.bG(this,a,b)},this);LK(this,a)};z.e.lb=function(a){a.preventDefault();MK(this,a.target)};z.e.uS=function(a){if(13===a.keyCode||32===a.keyCode)a.preventDefault(),MK(this,a.target)};z.e.Hi=function(a,b){a&&this.iz(b);z.xl(this.dJ,"display",a?"none":"block");z.xl(this.Cg,"display",a?"block":"none")};
z.e.iz=function(a){var b=this.sm,c=this.un,d=z.W.get(z.W.g.St);4===a&&(b=this.vt,c=this.uE,d=z.W.get(z.W.g.mK));this.Cg.innerHTML=d;this.p().Nd(this.Cg,"click",(0,z.s)(function(a){a.stopPropagation();this.Hi(!1);NK(this,b);c.apply(this)},this))};z.e.ao=function(a){a.stopPropagation();this.Hi(!1);NK(this,this.sm);this.un()};z.e.Or=function(a){var b=a.Yb;z.kb(a,{Yb:(0,z.s)(function(){b();this.Hi(!0,4)},this)})};
z.e.un=function(a){this.dispatchEvent({type:"sortOrderChanged",direction:a||"new",Yb:(0,z.s)(this.Id,this)})};z.e.uE=function(){this.dispatchEvent({type:"sortHotThreads",Yb:(0,z.s)(this.Id,this)})};z.e.LF=function(){var a=this.d.u;a.v();var b=z.F.k;z.F.id?(b=a.Kd(z.F.get(b.W)),a.Aj(!b),a=b?z.W.get(z.W.g.iu):z.W.get(z.W.g.ju),this.sl.innerHTML=a):z.Mh(this.d.Jc,(0,z.s)(this.LF,this))};
z.e.fo=function(){var a=this.d.u,b=a.v(),c=z.F.k,b=!b.Ld()||z.F.get(c.Xd);this.sl&&(b?z.N(this.sl,!1):(a=a.Kd(z.F.id)?z.W.get(z.W.g.ju):z.W.get(z.W.g.iu),this.sl.innerHTML=a,z.N(this.sl,!0)))};z.e.h=function(){KK.b.h.call(this);z.F.off(null,null,this)};z.v(OK,KK);OK.prototype.K=function(a){this.c=a;z.so(a,FK,this.s());this.sm=this.o("fyre-stream-sort-newest");this.xz=this.o("fyre-stream-sort-oldest");this.dJ=this.o("fyre-stream-sort-options");this.dd=this.o("fyre-content-loading");this.Id()};OK.prototype.un=function(a){this.dispatchEvent({type:"archiveSortOrderChanged",stream:this.ZX.stream,direction:a,Yb:(0,z.s)(this.Id,this)})};
OK.prototype.s=function(){return{j:{HO:z.W.get(z.W.g.gK),ey:z.W.get(z.W.g.Zp),fy:z.W.get(z.W.g.$p),Vo:z.W.get(z.W.g.oC),kp:z.W.get(z.W.g.dq)}}};z.v(PK,z.Xx);z.e=PK.prototype;z.e.jn=function(a){this.clear();z.N(this.c,!0);this.od=a};z.e.clear=function(){this.md.Lf();this.vb={};this.Ij=[];for(this.uh=this.Wk=null;this.ma&&0!=this.ma.length;)this.Oo(0).q()};z.e.K=function(a){PK.b.K.call(this,a);z.so(this.c,z.ar,this.s());this.ik=this.o("fyre-stream-content");this.Ii=this.o("fyre-stream-more");this.Ia.S(this.Ii);z.N(this.Ii,!1)};z.e.h=function(){this.Ia&&this.Ia.q();this.Ia=null;PK.b.h.call(this)};
z.e.m=function(){PK.b.m.call(this);this.p().e(this.Ia,"showMore",this.dx)};z.e.gw=function(){return this.L.J.QG};z.e.s=function(){return{be:z.w.H.ub,xv:!!this.Ia,j:{pz:z.W.get(z.W.g.hK)}}};z.e.ex=function(){this.Ia.rt();this.fh=!0};z.e.uy=function(){this.dispatchEvent({type:this.uu,direction:this.od,target:this,EY:this.fh&&this.ZI,Yb:(0,z.s)(this.ex,this),zj:(0,z.s)(this.oG,this)});this.fh&&(this.ZI=!1)};z.e.By=function(a){this.fh||PK.b.By.call(this,a)};
z.e.$o=function(){var a=this.L.Mb.Sk,b=this.od,c=a.d.u.v(),b="old"===b,c=c.get(z.U.Ep),c=!b&&a.gl>-c;b&&-1>a.gl||c?this.Ia.show():this.Ia.pb()};z.e.start=function(){this.fh||this.uy()};z.v(QK,z.cG);var dL=z.W.g,eL={};eL.comment=[dL.Sm,dL.Xf,dL.Hm];eL.liveblog=[dL.MM,dL.XL,dL.tB];QK.prototype.hF=function(a){function b(a){return z.Ha(a,"%s")?a:"%s "+a}var c=this.l.Ld()?"liveblog":"comment",c=eL[c];switch(a){case 1:c=b(z.W.get(c[1]));break;case 0:if(z.W.get(c[0])!==z.$F[c[0]]){c=z.W.get(c[0]);break}default:c=b(z.W.get(c[2]))}return z.wa(c,a)};z.v(RK,z.fu);RK.prototype.cp=200;RK.prototype.Yh=function(){return new SK(this.Ic)};RK.prototype.s=function(){var a={};a.message=this.Tz;return a};z.v(SK,z.$t);SK.prototype.Pc=function(a,b,c){var d=z.Wl(this.element),d=new z.yh(d.width,d.height+25);b=z.Vt(this.element,this.Mh,a,b,d,c,9);z.Dl(a.lastChild,0);b&&(d=new z.yh(0,-5),z.Vt(this.element,2,a,1,d,c,5),z.Dl(a.lastChild,a.offsetWidth-(this.element.offsetParent.offsetWidth-this.element.offsetLeft+this.element.offsetWidth/2)))};z.v(TK,z.T);z.e=TK.prototype;z.e.r=function(){this.c=z.vo(EK,this.s())};z.e.m=function(){TK.b.m.call(this);this.Xa=new RK(this.c,this.l.get("displayName"));this.p().e(this.c,"click",this.lb)};z.e.h=function(){TK.b.h.call(this);this.Xa&&this.Xa.q()};z.e.s=function(){var a=z.Od,b=this.zt,c={};c.Vc=this.l.get(a.xb);c.ec=this.l.get(a.vk);c.aa=this.l.get(a.va);c.id=this.l.id;c.aU=this.l.id.replace(/[@.]/g,"-");c.Aa=this.l.get(a.ac);c.j={profile:b.get(b.g.UL),Vc:b.get(b.g.SL)};return c};
z.e.lb=function(a){a.preventDefault();a.stopPropagation();this.dispatchEvent({t:this.l,type:"author_click"})};z.v(UK,z.T);z.e=UK.prototype;z.e.xB=10;z.e.h=function(){UK.b.h.call(this);delete this.Ec};z.e.R=function(){UK.b.R.call(this);this.Ec.off(null,null,this)};z.e.vF=function(a){a=new TK(a);var b=this.Nc();if(b===this.xB){var c=this.Oo(b-1);c&&(c.q(),b--)}0<b?this.Fe(a,0,!0):this.D(a,!0)};z.e.eT=function(a){var b;this.Mc(function(c){a.id===c.l.id&&(b=c)});b&&(this.removeChild(b),b.q())};
z.e.bo=function(){this.Ec.on(this.Ec.Ca.Qt,this.vF,this);this.Ec.on(this.Ec.Ca.qu,this.eT,this);var a=this.Ec.ib.reverse().slice(0,this.xB);z.y(a,this.vF,this)};z.v(VK,UK);z.v(XK,z.mG);
XK.prototype.tI=function(a,b){if(!this.La){this.w=b;var c=b.get(z.U.Ch),d=b.get(z.U.Zd);this.Kt=new z.jG(c,d,a.J.Ra);this.D(this.Kt);this.Jq=new QK(a.u.v());this.D(this.Jq);this.As=null;b.qo()&&(this.Ru=new OK(a),this.D(this.Ru),this.Tk=new PK(a),this.D(this.Tk),CK(this.Ru,{stream:this.Tk}));this.rh=new KK(a);this.D(this.rh);this.ss((0,z.s)(function(a){this.Vb=a;this.D(this.Vb);a=this.Vb;this.ba&&a&&a.S(this.je,!0)},this));b.get(z.U.Nm)&&!z.Xf&&this.w.fr()&&(this.w.gh()||this.w.Ld()||this.Jw())}};
XK.prototype.s=function(){return{Ra:this.d.J.Ra,gh:this.w.gh(),Ld:this.w.Ld(),re:z.Xf,sU:this.d.J.qD,qo:this.w.qo()}};z.ly={dZ:"fyre-archive-stream",eZ:"fyre-archive-stream-header",W1:"fyre-top-content-stream",p2:"fyre-widget",Nm:"fyre-featured-content-wrapper"};z.kb(z.ly,z.gK);z.e=XK.prototype;
z.e.r=function(){this.c=z.vo(DK,this.s());var a=this.w.get(z.U.bj);if(1!==a){var b=this.d.Jb,a=2===a?3:4,c=this.o("fyre-top-content-stream");z.oz(b,a,c,this)}this.Wr.S(this.o(z.ly.GL));this.Tk&&(b=this.o("fyre-archive-stream-header"),this.Ru.S(b),this.Tk.S(this.o("fyre-archive-stream")));this.Nh(1);this.je=this.o(z.ly.zh);b=YK(this);z.N(this.je,b)};
z.e.m=function(){XK.b.m.call(this);var a=this.Vb;this.ba&&a&&a.S(this.je,!0);this.d.U.mp("stream_data_received",this.fS,this);this.p().e(this,"request_content_context",this.ER).e(this,"request_content_reply",this.hT);this.Tk&&this.Tk.start()};z.e.bo=function(){this.Fn&&this.Fn.bo()};z.e.fS=function(){var a=this.w,b=a.get(z.U.zk);z.ph||b||(b=(0,z.s)(function(){this.As=new z.fL(this.d,a.get(z.U.Zd));this.D(this.As,!0)},this),z.dg(z.w.H.ub+z.w.kh.As,null,null,b))};
z.e.Jw=function(){var a=new z.SE(this.bH,this);a.TH=(0,z.s)(this.XW,this);var b=(0,z.s)(function(){a.start(0,2E3)},this);z.dg(z.w.H.ub+z.w.kh.oQ,null,null,b)};z.e.XW=function(){var a=this.o("fyre-featured-content-wrapper");this.Qv=new z.wK(this.d);this.D(this.Qv);this.Qv.S(a);this.Qv.eh()};z.e.ss=function(a){if(!this.d.J.readOnly){var b=this.d.u.v();z.bx(z.Zw.C(),"main",a,{L:this.d,Ai:"new"},b);z.F.on(z.F.nc(z.F.k.W),this.Zc,this)}};z.e.Zc=function(){if(this.je){var a=YK(this);z.N(this.je,a)}};
z.e.ci=function(){0<z.Cp(this,this.Vb)&&(this.removeChild(this.Vb),this.Vb.q());this.ss((0,z.s)(function(a){this.Vb=a;this.D(this.Vb);a=this.Vb;this.ba&&a&&a.S(this.je,!0);z.N(this.je,!0)},this))};z.e.dh=function(a,b){null!=a&&(this.d.Jb.xl(1),(0,window.setTimeout)((0,z.s)(function(){var c=b&&function(a){z.Yw(a.Qa)};this.La||z.nG(this,a,c)},this),3E3))};z.e.ER=function(a){z.nG(this,a.Zk)};z.e.hT=function(a){z.nG(this,a.Zk,function(a){z.Yw(a.Qa)})};
z.e.h=function(){XK.b.h.call(this);z.F.off(z.F.nc(z.F.k.W),this.Zc,this);this.w&&(this.w.off(null,null,this),this.w=null)};z.v(ZK,z.sG);z.e=ZK.prototype;z.e.oe=function(a,b){ZK.b.oe.call(this,a,b);a.e(b,"repliesExpanded",this.IF);a.e(b,"sortHotThreads",this.sT);a.e(b,"sortOrderChanged",this.rG);a.e(b,"sortTopComments",this.tT);a.e(b,"archiveShowMore",this.mR);a.e(b,"archiveSortOrderChanged",this.nR)};
z.e.mR=function(a){var b=a.Yb||z.n,c=(0,z.s)(this.Te,this,a.target),d=this.d.Mb;a=a.EY;d.Sk||(d.Sk=new BK(d.L));d=d.Sk;a=a?d.gl:AK(d);var f=d.ed[a];f&&(d.gl=a);if(f)b(),c(f);else{d=this.d.Mb.tl();a=d.k.qf;if(d.get(a))b();else d.on(d.nc(a),b,this);z.tG(this,d,c)}};z.e.Ew=function(a,b){var c=2===b.Sc,d=1!==b.Sc;switch(b.type){case 0:var f=this.d.u.v(),f=z.Hm(b,f),g=f.get(z.Um),g=this.d.u.gb().get(g);f.set(z.Im,g);a.Vw(f,c,d)}};
z.e.hG=function(a){if(1!==this.Xm){var b=this.RX.rh;b.Hi(!1);NK(b,b.sm);z.kb(a,{direction:"new",Yb:z.n});this.rG(a)}};z.e.nR=function(a){z.uG(this);a.stream.jn(a.direction);var b=this.d.Mb.tl(a.direction,!0),c=(0,z.s)(function(b){a.Yb();this.Te(a.stream,b)},this);z.tG(this,b,c,a.zj)};z.e.rG=function(a){this.d.J.ii=null;var b=z.wG(this,1);z.$v(this.d.Mb);b.jn(a.direction);var c=z.Zv(this.d.Mb,a.direction),d=(0,z.s)(function(c){a.Yb();this.Te(b,c)},this);z.tG(this,c,d,a.zj)};
z.e.tT=function(a){var b=z.wG(this,3),c=this.d.Mb.Sh("likes");z.tG(this,c,(0,z.s)(function(c){a.Yb();z.hb(c)?z.Wx(b):this.Te(b,c)},this))};z.e.sT=function(a){var b=z.wG(this,4),c=this.d.Mb.Wh();z.tG(this,c,(0,z.s)(function(c){a.Yb();z.hb(c)?z.Wx(b):this.Te(b,c)},this))};z.v($K,z.Ss);z.e=$K.prototype;z.e.c=null;z.e.h=function(){$K.b.h.call(this);this.xt.q();this.LD.q();this.Ub.ba&&this.Ub.q();this.Vf&&this.Vf.q();delete this.Vf};z.e.Il=function(a){$K.b.Il.call(this,a);this.xt=new ZK(this.d);this.xt.handle(a);this.LD=new z.pG(this.d);this.LD.handle(a)};z.e.Gz=function(){this.d.Ki.stop()};z.e.YX=function(){this.d.Sl.stop()};z.e.fk=function(){this.d.Ki.start()};z.e.VX=function(){this.d.Sl.start()};
z.e.ra=function(){this.Vf&&this.Vf.q();this.Ub.ra(this.c);this.d.Lb.send(z.Wn("Load"));var a=z.Us(window.location,"reply_editor");if("object"===typeof window.Livefyre&&window.Livefyre.sO)z.Ys(this,a);else{var b=z.Vs(this);this.Ub.dh(b,a)}this.d.U.N("render_complete",this.c)};z.v(aL,z.Fn);aL.prototype.bD=HK.C();aL.prototype.h=function(){aL.b.h.call(this);this.stop();delete this.J;delete this.ha;bL(this);z.Kn(this);this.yj&&(this.yj.q(),delete this.yj)};aL.prototype.Oz=function(){this.stop();bL(this);aL.b.Oz.call(this)};z.jg.main.Oh.ia(aL);})(fyre.conv);
