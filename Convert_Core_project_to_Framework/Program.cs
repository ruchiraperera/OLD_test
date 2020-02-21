using System;


/*
 * replace
 * <TargetFramework>netcoreapp1.1</TargetFramework>
 * 
 * to
 * 
 *  <TargetFramework>net472</TargetFramework>
 *  
 *  in *.csproj file
 *  
 *  In your .csproj file, inside of the <PropertyGroup></PropertyGroup> tag, modify <TargetFramework> to reflect the following:
    <TargetFramework>net461</TargetFramework>
 */




namespace Convert_Core_project_to_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
