using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace ExampleApp
{
  public static class BookStore
  {
    private static Timer _timer = new Timer();
    private static int _bookSales = 1450;
    public static int DailyBookSales
    {
      get  { return _bookSales; }
    }
    public static int GetDailyBookSales()
    {
      return _bookSales;
    }

    #region Other

    private static Random _random = new Random();
    static BookStore()
    {
      _timer.Interval = 1100;
      _timer.Elapsed += Timer_Elapsed;
      _timer.Start();
    }

    private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
      _bookSales += _random.Next(5, 15);
    }

    public static Book GetTopSeller()
    {
      // simulate get the top book


      var topBook = new Book { Author = "Walt Ritscher", Title = "HLSL and Pixel Shaders for XAML Developers", Price = 9.95M };
      return topBook;

    }

    public static void UpdateBookPrice(Book book, decimal percentChanged)
    {
      book.Price *= percentChanged;
      // update Database

    }
  } 
  #endregion
}
