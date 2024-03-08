// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.Browser;

var Driver = new ChromeDriver();

Driver.Manage().Window.Size = new Size(600, 800);
Driver.Navigate().GoToUrl("https://music.j-total.net/sp/");

Main();

void Main()
{
    Console.WriteLine("\n\n\n\n\n**********************************************************************");
    Console.WriteLine("**********************************************************************"); 
    Console.WriteLine("**********************************************************************");
    Console.WriteLine("準備が整いました。1:開始,0:終了");
    Console.WriteLine("**********************************************************************");
    Console.WriteLine("**********************************************************************");
    Console.WriteLine("**********************************************************************\n\n\n\n\n");
    string input = Console.ReadLine() + "";

    if (input == "1")
    {
        string f_name=search_title();
        //
        //コード変更処理
        //
        Console.WriteLine($"{f_name}");
        output_txt(ref f_name);

        Console.WriteLine("\n書き込みが終了しました");
        Main();
    }
    else if (input == "0")
    {
        return;
    }
    else
    {
        Console.WriteLine("入力ミスです");
        Main();
    }
    return;
}

string search_title()
{
    var result = Driver.FindElements(By.XPath(@"//*[@class='box2']"));


    foreach (var element in result) 
    {
        string originalString = element.Text;

        string delimiter = "\n";

        int delimiterIndex = originalString.IndexOf(delimiter);

        string extractedString = originalString.Substring(0, delimiterIndex);

        return extractedString;
    }
    return "";
}

void output_txt(ref string File_name)
{
    var code = Driver.FindElements(By.TagName("tt"));

    string title = File_name.Replace("\n","");
    title = title.Replace("\r", "");
    title =title+ ".txt";
    using (StreamWriter sw = new StreamWriter(@"codes\"+title, false,
                                    Encoding.GetEncoding("utf-8")))
    {
        foreach (var item in code)
        {

            {
                sw.WriteLine(item.Text);
            }
            
        }
       
        sw.Close();
    }
  

}
