# 🚀 Greed Island: Cyber Collection - PF_LAB3 (Ultra-Modern Futuristic Edition)

A Hunter x Hunter themed web application for creating and managing character cards, built with ASP.NET Core MVC and Entity Framework Core.

## 📋 Project Overview

This application allows users to create, manage, and organize Hunter x Hunter character cards inspired by the Greed Island game. Features include user authentication, CRUD operations, and a themed user interface.

## 🛠️ Technology Stack

- **Framework**: ASP.NET Core 8.0 MVC
- **Database**: SQL Server with Entity Framework Core
- **Authentication**: ASP.NET Core Identity
- **UI Framework**: Bootstrap 5
- **Icons**: Font Awesome 6
- **Development Tools**: Visual Studio 2022

## 📦 Dependencies

The following NuGet packages are included:

- Microsoft.AspNetCore.Identity.EntityFrameworkCore (8.0.0)
- Microsoft.AspNetCore.Identity.UI (8.0.0)
- Microsoft.EntityFrameworkCore.SqlServer (8.0.0)
- Microsoft.EntityFrameworkCore.Tools (8.0.0)
- Microsoft.VisualStudio.Web.CodeGeneration.Design (8.0.0)

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET 8.0 SDK
- SQL Server or SQL Server LocalDB

### Installation Steps

1. **Clone the Repository**
   ```bash
   git clone [repository-url]
   cd PF_LAB3_BSIT32A1_Terrance_Soriano
   ```

2. **Restore NuGet Packages**
   ```bash
   dotnet restore
   ```

3. **Update Connection Strings**
   - Open `appsettings.json`
   - Verify the connection strings point to your SQL Server instance:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PF_LAB3_Identity;Trusted_Connection=true;MultipleActiveResultSets=true",
       "GreedConnection": "Server=(localdb)\\mssqllocaldb;Database=PF_LAB3_Greed;Trusted_Connection=true;MultipleActiveResultSets=true"
     }
   }
   ```

4. **Run Database Migrations**
   
   For Identity Database:
   ```bash
   dotnet ef migrations add InitialCreate --context ApplicationDbContext
   dotnet ef database update --context ApplicationDbContext
   ```
   
   For Cards Database:
   ```bash
   dotnet ef migrations add InitialCreate --context GreedDbContext
   dotnet ef database update --context GreedDbContext
   ```

5. **Build and Run the Application**
   ```bash
   dotnet build
   dotnet run
   ```

6. **Access the Application**
   - Open your browser and navigate to `https://localhost:5001` or `http://localhost:5000`

## 🏗️ Project Structure

```
PF_LAB3_BSIT32A1_Terrance_Soriano/
├── Controllers/
│   ├── HomeController.cs
│   └── CardsController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   └── GreedDbContext.cs
├── Models/
│   ├── Card.cs
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Cards/
│   │   ├── Index.cshtml
│   │   ├── Details.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Delete.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       └── Error.cshtml
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
├── appsettings.json
├── Program.cs
└── README.md
```

## 💾 Database Schema

### ApplicationDbContext (Identity)
- Standard ASP.NET Core Identity tables for user management

### GreedDbContext (Cards)
- **Cards Table**: Stores card information with the following structure:
  - Id (Primary Key)
  - Name (Required, Max 100 chars)
  - CharacterName (Required, Max 100 chars)
  - Rarity (Enum: Common, Uncommon, Rare, SuperRare, UltraRare, Legendary)
  - CardType (Enum: Attack, Defense, Magic, Item, Spell, Transform)
  - CardNumber (Integer)
  - PowerLevel (1-10)
  - CharacterImageUrl (Optional URL)
  - Description (Max 500 chars)
  - SpecialAbility (Max 200 chars)
  - DateCreated (DateTime)
  - CreatedByUserId (Foreign Key to Identity User)

## 🎮 Features

### User Authentication
- User registration and login
- Password requirements (minimum 6 characters, requires digit and lowercase)
- Individual user sessions

### Card Management (CRUD Operations)
- **Create**: Add new character cards with all properties
- **Read**: View all cards and individual card details
- **Update**: Edit existing cards (owner only)
- **Delete**: Remove cards from collection (owner only)

### User Interface
- **🌌 Ultra-Modern Futuristic Dark Theme**: Sleek black backgrounds with neon cyan, purple, and green accents
- **🎮 Cyber Greed Island Theme**: Next-gen Hunter x Hunter styling with cyberpunk aesthetics
- **⚡ Advanced Animations**: Glowing effects, pulse animations, and dynamic scanlines
- **🔥 Interactive Elements**: 3D hover effects, gradient borders, and animated backgrounds
- **🎨 Neon Color Palette**: Cyan (#00ffff), Purple (#bf00ff), Green (#39ff14), Pink (#ff1493), Orange (#ff6600)
- **✨ Premium Typography**: Inter + JetBrains Mono fonts for futuristic appeal
- **🌟 CSS Custom Properties**: Advanced theming system with gradient variables
- **📱 Next-Gen Responsive**: Optimized for all devices with smooth transitions
- **⚛️ Modern UI Components**: Enhanced cards, buttons, forms with cybernetic styling
- **🔮 Neural Network Aesthetics**: Grid patterns, scanlines, and digital matrix effects

### Security Features
- User authentication required for card operations
- Users can only edit/delete their own cards
- Anti-forgery token protection
- Input validation and sanitization

## 🔧 Development Commands

### Entity Framework Commands

**Add Migration**
```bash
dotnet ef migrations add [MigrationName] --context [ContextName]
```

**Update Database**
```bash
dotnet ef database update --context [ContextName]
```

**Remove Last Migration**
```bash
dotnet ef migrations remove --context [ContextName]
```

### Build and Run Commands

**Clean Build**
```bash
dotnet clean
dotnet build
```

**Run with Hot Reload**
```bash
dotnet watch run
```

**Run Specific Environment**
```bash
dotnet run --environment Development
```

## 🎨 Customization

### Theming
- **Dark Theme**: Modern dark color palette with CSS custom properties
- **Primary Colors**: Blue accent colors with Hunter x Hunter elements
- **Enhanced Styling**: Gradients, shadows, and smooth animations
- Modify `wwwroot/css/site.css` for custom styling
- Update `_Layout.cshtml` for global layout changes
- **CSS Variables**: Easy theme customization through CSS custom properties

### Adding New Card Properties
1. Update the `Card` model in `Models/Card.cs`
2. Add migration: `dotnet ef migrations add AddNewProperty --context GreedDbContext`
3. Update database: `dotnet ef database update --context GreedDbContext`
4. Update views and controller accordingly

## 🐛 Troubleshooting

### Common Issues

**Database Connection Issues**
- Verify SQL Server is running
- Check connection strings in `appsettings.json`
- Ensure databases exist and migrations are applied

**Migration Issues**
- Delete migration files and recreate if needed
- Check for model validation errors
- Ensure correct context is specified

**Authentication Issues**
- Clear browser cookies and try again
- Verify Identity services are properly configured in `Program.cs`

### Getting Help
- Check the `ASSIGNMENT.md` file for specific requirements
- Review error messages in browser developer tools
- Check Visual Studio Output window for detailed error information

## 📝 Assignment Requirements

This project fulfills the following requirements:
- ✅ MVC Architecture implementation
- ✅ Individual user authentication
- ✅ Card model with required properties
- ✅ Two separate database contexts
- ✅ CardsController with full CRUD operations
- ✅ Five view templates with detailed instructions
- ✅ Hunter x Hunter Greed Island theme
- ✅ Bootstrap styling framework
- ✅ Complete technical documentation

## 👨‍💻 Development Notes

- The project uses separate database contexts for Identity and application data
- Seed data is included for testing purposes
- All views include detailed TODO comments for educational purposes
- The application follows ASP.NET Core best practices and conventions

---
*Hunter x Hunter © Yoshihiro Togashi. This project is for educational purposes only.*
