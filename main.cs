using System;

class MainClass {
  public static void Main (string[] args) {
    CheckMagazine("","");
  }

  public static void CheckMagazine(List<string> magazine, List<string> note)
  {
      //Solution 1 : Using Dictionary

      //Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
      //foreach (var a in magazine)
      //{
      //    if (keyValuePairs.ContainsKey(a))
      //    {
      //        var value = keyValuePairs[a];
      //        keyValuePairs.Remove(a);
      //        keyValuePairs.Add(a, value + 1);
      //    }
      //    else
      //    {
      //        keyValuePairs.Add(a, 1);
      //    }
      //}

      //foreach(var b in note)
      //{
      //    if (!keyValuePairs.ContainsKey(b))
      //    {
      //        Console.WriteLine("No");
      //    }
      //    else
      //    {
      //        var value = keyValuePairs[b];
      //        if (value == 1)
      //        {
      //            keyValuePairs.Remove(b);
      //        }
      //        else
      //        {
      //            keyValuePairs.Remove(b);
      //            keyValuePairs.Add(b, value - 1);
      //        }
      //    }
      //}
      //Console.WriteLine("Yes");


      //Solution 2 : Using lists

      magazine.Sort();
      note.Sort();

      foreach(var a in note)
      {
          if (!magazine.Remove(a))
          {
              Console.WriteLine("No");
              return;
          }
      }
      Console.WriteLine("Yes");
  }
}