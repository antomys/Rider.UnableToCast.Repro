// See https://aka.ms/new-console-template for more information


using Rider.Repro;

var tst = QueryBuilder.Create(1)
    .AddArray(null!, string.Empty)
    .Build();
    
return 0;