using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model_binding_and_validating_data
{
    class Program
    {
        static void Main(string[] args)
        {
            ////
            /// model binding => allow use to create .net objects from the data in an http request and 
            /// used as a parameters for action methods
            /// [bind("object name")] PieModelView pieModelView
            /// 
            /// example 01 
            /// public class PieModelView {
            ///     public Pie pie { get; set; }
            ///     public string CategoryId {get; set;}
            /// }
            /// 
            /// but for returns only pie.name
            /// 
            /// therefore in method parameters we define as [bind("Pie")] PieModelView pieViewModel
            /// then its only bind pie property only 
            /// 
            /// there types of binding
            /// 01. bind => it will bind matching fields (optional all)
            /// 02. bind never => it will not bind [bindnever] atrribute fields ( no need)
            /// 03. bind required => its required to bind those fields (no optional) 
            /// 
            /// Specify other binding source [fromQuery] [FromHeader(name = "Accept-Language")] [fromRoute]
            /// 
            /// *** write overide custom model binder with DefaultModelBinder class (inheritance) - IModelBinder
            /// this will use to write global custom binder 
            /// 
            /// 
            /// remote validation
            /// [Remote("method name","controller name",Error Message="")]
            /// -
            /// Controller.cs
            /// public IActionResult MethodName([bind(prefix="pie.name")] string name){
            ///     return 1=1 ? Json(true) : Json ("This pie name is already taken");
            /// }
            /// 
            /// [FromBody] only from body. 
            /// 
            /// 
            /// 
            /// 






























            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
