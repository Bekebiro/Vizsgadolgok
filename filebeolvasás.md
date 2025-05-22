# File beolvasás
```c#
  List<data> list = new List<data>();
    StreamReader reader = new StreamReader("ajto.txt");
    while (!reader.EndOfStream)
    {
        list.Add(new data(reader.ReadLine()));
    }
    reader.Close();

```

# File írás
```c#
StreamWriter writer = new StreamWriter("athaladas.txt");
            for (ii = 0;ii < 100; ++ii) 
            {
                if (counter[ii] != 0)
                {
                    writer.WriteLine($"{ii+1} {counter[ii]}");
                } 
            }
            writer.Close();
```