# hotchocolate schema stitching poc setcup

Solution

```bash=
dotnet new sln -n Gateway
dotnet new web -o Products
dotnet new web -o Reviews
dotnet new web -o Gateway
dotnet sln add Products Reviews Gateway
dotnet new gitignore
```

Add hotchocolate to Reviews and Products

```bash=
dotnet add Products package HotChocolate.AspnetCore
dotnet add Products package HotChocolate.Data

dotnet add Reviews package HotChocolate.AspnetCore
dotnet add Reviews package HotChocolate.Data

dotnet add Gateway package HotChocolate.AspnetCore
dotnet add Gateway package HotChocolate.Stitching
```

Code 
```
mkdir Reviews/src ; mv ./Reviews/*.cs ./Reviews/src
mkdir Products/src; mv ./Products/*.cs ./Products/src
mkdir Gateway/src; mv ./Gateway/*.cs ./Gateway/src

touch ./Reviews/src/ReviewService.cs ./Reviews/src/Query.cs
touch ./Products/src/ProductService.cs ./Products/src/Query.cs
```
