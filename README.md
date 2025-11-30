# 3. zh
Tools -> NuGet Package Manager -> Package manager Console

***Add-Migration [Nev]***

***Update-Database***

## 1. Projekt létrehozása
- new project -> ASP.NET Core Web App (Model-View-Controller)

## 2. NuGet Packages
- Microsoft.EntityFrameworkCore 9.0.10
- Microsoft.EntityFrameworkCore.Sqlite 9.0.10
- Microsoft.EntityFrameworkCore.Tools 9.0.10

## 3. Model osztályok létrehozása (3, 4, 5 sorrendje a feladat kiírása alapján változhat)

## 4. Context
- Context mappa létrehozása
- EFContext osztály létrehozása
```cs
using asp_net.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net.Context
{
  public class EFContext : DbContext
  {
    public virtual DbSet<[ModelNeve]> [Nev] { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=./DB/db.db");
    }
  }
}
```

## 5. DB mappa létrehozása
- Üresen marad!

## 6. Program.cs-be:

```cs
// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context.EFContext>(); //Ezt hozza kell addni
```

## 7. Controller
- Contoller mappára jobb katt -> Add -> Controller -> Add MVC Controller with vievs, using Entity Framework
- Mind két modellre

## 8
- Views -> Shared -> _Layout.cshtml
- body-ba bele kell tenni a modellek címkéit
```cshtml
<li class="nav-item">
    <a class="nav-link text-dark" asp-area="" asp-controller="[ControllerNeve(Players)]" asp-action="Index">[ControllerNeve(Players)]</a>
</li>
``` 

## Side notes
### Ha enum van:
- Views -> [Model]s -> Create.cshtml, Edit.cshtml

Előtte:
```cshtml
<div class="form-group">
    <label asp-for="Position" class="control-label"></label>
    <select asp-for="Position" class="form-control"></select>
    <span asp-validation-for="Position" class="text-danger"></span>
</div>
```
Utána:
```cshtml
<div class="form-group">
    <label asp-for="Position" class="control-label"></label>
    <select asp-for="Position" class="form-control" asp-items="Html.GetEnumSelectList<Position>()"></select>
    <span asp-validation-for="Position" class="text-danger"></span>
</div>
```
### Ha valami nem jelenik meg a kistában jól hozzáadásnál
- a [Model]sController.cs-ben át kell írni a ViewData sorok utolsó idézőjeles attribútumát olyanra, amit akarunk

Előtte:
```cshtml
ViewData["TeamId"] = new SelectList(_context.Teams, "Id", "Id", player.TeamId);
```
Utána:
```cshtml
ViewData["TeamId"] = new SelectList(_context.Teams, "Id", "TeamName", player.TeamId);
```
- És a Views -> Players -> Index.cshtml-ben ezt a kettőt is

Előtte:
```cshtml
<th>
@Html.DisplayNameFor(model => model.ReferencedTeam)
</th>
```

Utána:
  ```cshtml
<th>
@Html.DisplayNameFor(model => model.ReferencedTeam.TeamName)
</th>
```          
### Ha rendezés van
Playercontroller.cs
```cs
// GET: Players
public async Task<IActionResult> Index(
string? SortOrder, Position? PositionFiller, string? NameFiller, bool RetiredFiller
)
{
var eFContext = _context.Players.Include(p => p.ReferencedTeam);
var res = eFContext.AsQueryable();

if (SortOrder != null && SortOrder.Equals("up"))
{
    res = res.OrderBy(e => e.Name);
}
if (SortOrder != null && SortOrder.Equals("down"))
{
    res = res.OrderByDescending(e => e.Name);
}


return View(await res.ToArrayAsync());
}
```

Views -> [Model]s -> Index.cshtml
```cshtml
<p>
    <a asp-action="Create">Create New</a>
</p>
<table class="table">
    <thead>
        <tr>
            <th>
                @* ez lett atirva *@
                @Html.DisplayNameFor(model => model.Name)
                <a asp-controller="Players" asp-action="Index" asp-route-SortOrder="up">&#x2582</a>
                <a asp-action="Index" asp-route-SortOrder="down">&#x25BC</a>
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Age)
</th>
```