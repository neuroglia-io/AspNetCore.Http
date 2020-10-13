# AspNetCore.Http
A NET CORE 3.1 library that provides tools to extend AspNetCore Http

# Usage

[Nuget Package](https://www.nuget.org/packages/Neuroglia.AspNetCore.Http/)

```
  dotnet add package Neuroglia.AspNetCore.Http
```

## Sample Code

### Add Istio headers propagation

```C#
public void ConfigureServices(IServiceCollection services)
{
    ...
    services.AddIstioHeadersPropagation();
    ...
}
```

# Contributing

Please see [CONTRIBUTING.md](https://github.com/neuroglia-io/AspNetCore.Http/blob/master/CONTRIBUTING.md) for instructions on how to contribute.
