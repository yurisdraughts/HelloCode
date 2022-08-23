using System.Linq;

var data = new int[] {1,2,3,4}
           .Where(e => e > 0)
           .Select(e => new {q = e, w = e+1});

Console.WriteLine(data.GetType());
//System.Linq.Enumerable+WhereSelectArrayIterator`2[System.Int32,<>f__AnonymousType0`2[System.Int32,System.Int32]]
//подобный тип невозможно задать иначе, чем через var