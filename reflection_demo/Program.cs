// See https://aka.ms/new-console-template for more information
using Reflection_NameShow;
using System;
using System.Reflection;


public class Example
{
     public static void Main()
    {
        Console.WriteLine(System.Environment.CurrentDirectory);
        Assembly SampleAssembly = Assembly.LoadFrom("C:\\Users\\Torre\\Documents\\Coding\\C#\\reflection_demo\\reflection_demo\\bin\\Debug\\net6.0\\Reflection_NameShow");

        foreach (var type in SampleAssembly.GetTypes())
        {
            Console.WriteLine(type);
        }

        Console.WriteLine("*************************");

        Type  typeReflectionshowname = SampleAssembly.GetType("Reflection_NameShow.Reflectionshowname");

        foreach(var method in typeReflectionshowname.GetMethods())
        {
            Console.WriteLine(method); //变量类的方法
        }

        MethodInfo method1 = typeReflectionshowname.GetMethod("Name");//



        object O = Activator.CreateInstance(typeReflectionshowname);

        method1.Invoke(O, new object[] { });

        //Ishowname ishow = (Ishowname)O;
        //ishow.Name();



    }

}
