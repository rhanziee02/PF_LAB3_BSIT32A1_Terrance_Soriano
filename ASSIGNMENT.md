# PF_LAB3 Assignment - Grading Criteria and Requirements

**Course**: Programming Fundamentals - Lab 3  
**Student**: Terrance Soriano  
**Section**: BSIT32A1  
**Theme**: Hunter x Hunter Greed Island: Cyber Collection (Ultra-Modern Futuristic Edition)

---

## 📊 Grading Breakdown (Total: 100 Points)

### 1. MVC Architecture Implementation (15 Points)

**Requirements:**
- ✅ **Models** (5 pts): Properly structured Card model with all required properties
- ✅ **Views** (5 pts): Complete view templates with proper structure and organization
- ✅ **Controllers** (5 pts): CardsController with all CRUD operations

**Grading Criteria:**
- **Excellent (5 pts)**: Full implementation following MVC best practices
- **Good (4 pts)**: Complete implementation with minor issues
- **Satisfactory (3 pts)**: Basic implementation with some structural problems
- **Needs Improvement (2 pts)**: Incomplete or poorly structured implementation
- **Unsatisfactory (0-1 pts)**: Missing or fundamentally flawed implementation

### 2. User Authentication (15 Points)

**Requirements:**
- ✅ **Identity Integration** (8 pts): ASP.NET Core Identity properly configured
- ✅ **User Sessions** (4 pts): Individual user authentication working
- ✅ **Access Control** (3 pts): Users can only edit/delete their own cards

**Grading Criteria:**
- **Excellent (13-15 pts)**: Complete authentication system with proper security
- **Good (10-12 pts)**: Functional authentication with minor security issues
- **Satisfactory (7-9 pts)**: Basic authentication working
- **Needs Improvement (4-6 pts)**: Incomplete authentication implementation
- **Unsatisfactory (0-3 pts)**: Authentication not functional

### 3. Database Implementation (20 Points)

**Requirements:**
- ✅ **ApplicationDbContext** (5 pts): Proper Identity context setup
- ✅ **GreedDbContext** (5 pts): Card data context with proper configuration
- ✅ **Card Model Properties** (5 pts): All required fields implemented
- ✅ **Database Relationships** (3 pts): Proper foreign key relationships
- ✅ **Data Validation** (2 pts): Model validation attributes

**Grading Criteria:**
- **Excellent (18-20 pts)**: Complete database setup with best practices
- **Good (14-17 pts)**: Functional database with minor configuration issues
- **Satisfactory (10-13 pts)**: Basic database functionality
- **Needs Improvement (6-9 pts)**: Database partially functional
- **Unsatisfactory (0-5 pts)**: Database not functional or missing

### 4. CRUD Operations (20 Points)

**Requirements:**
- ✅ **Create** (5 pts): Add new cards with full validation
- ✅ **Read** (5 pts): Display all cards and individual card details
- ✅ **Update** (5 pts): Edit existing cards with proper authorization
- ✅ **Delete** (5 pts): Remove cards with confirmation and authorization

**Grading Criteria:**
- **Excellent (18-20 pts)**: All CRUD operations fully functional with proper validation
- **Good (14-17 pts)**: Most operations working with minor issues
- **Satisfactory (10-13 pts)**: Basic CRUD functionality
- **Needs Improvement (6-9 pts)**: Some operations missing or buggy
- **Unsatisfactory (0-5 pts)**: CRUD operations not functional

### 5. User Interface and Theme (15 Points)

**Requirements:**
- ✅ **Greed Island Theme** (5 pts): Hunter x Hunter themed styling throughout
- ✅ **Bootstrap Integration** (4 pts): Proper use of Bootstrap components
- ✅ **Responsive Design** (3 pts): Works on mobile and desktop
- ✅ **User Experience** (3 pts): Intuitive navigation and layout

**Grading Criteria:**
- **Excellent (13-15 pts)**: Outstanding visual design with complete theme implementation
- **Good (10-12 pts)**: Good visual design with theme mostly applied
- **Satisfactory (7-9 pts)**: Basic styling with some theme elements
- **Needs Improvement (4-6 pts)**: Minimal styling or incomplete theme
- **Unsatisfactory (0-3 pts)**: Poor or no styling/theming

### 6. View Templates with TODO Instructions (10 Points)

**Requirements:**
- ✅ **Five Views** (2 pts each): Index, Details, Create, Edit, Delete
- Each view must contain detailed TODO comments for student learning

**Grading Criteria:**
- **Excellent (9-10 pts)**: All 5 views complete with comprehensive TODO instructions
- **Good (7-8 pts)**: All views present with good instructions
- **Satisfactory (5-6 pts)**: All views present with basic instructions
- **Needs Improvement (3-4 pts)**: Some views missing or poor instructions
- **Unsatisfactory (0-2 pts)**: Views missing or no instructions

### 7. Code Quality and Documentation (5 Points)

**Requirements:**
- ✅ **Code Comments** (2 pts): Meaningful comments throughout code
- ✅ **README.md** (2 pts): Complete technical documentation
- ✅ **Code Organization** (1 pt): Clean, organized project structure

**Grading Criteria:**
- **Excellent (5 pts)**: Excellent documentation and code organization
- **Good (4 pts)**: Good documentation with minor issues
- **Satisfactory (3 pts)**: Basic documentation
- **Needs Improvement (1-2 pts)**: Poor documentation
- **Unsatisfactory (0 pts)**: No documentation

---

## ✅ Requirements Checklist

### Core Functionality
- [x] **MVC Architecture**: Proper separation of Models, Views, and Controllers
- [x] **Individual Authentication**: Users must log in to access card features
- [x] **Card Model**: Complete with Name, Rarity, Character, and other properties
- [x] **Two Database Contexts**: ApplicationDbContext and GreedDbContext
- [x] **CRUD Operations**: Full Create, Read, Update, Delete functionality
- [x] **Authorization**: Users can only modify their own cards

### User Interface Requirements
- [x] **Five View Templates**: Index, Details, Create, Edit, Delete
- [x] **TODO Comments**: Detailed instructions in every view
- [x] **Greed Island Theme**: Hunter x Hunter styling with modern dark theme
- [x] **Bootstrap Framework**: Responsive design using Bootstrap 5 with enhanced styling
- [x] **Navigation**: Clear navigation between pages
- [x] **Form Validation**: Client and server-side validation

### Technical Requirements
- [x] **ASP.NET Core 8.0**: Latest framework version
- [x] **Entity Framework Core**: Database ORM implementation
- [x] **SQL Server**: Database backend
- [x] **Identity Framework**: User authentication system
- [x] **Connection Strings**: Proper database configuration
- [x] **Migrations**: Database schema management

### Documentation Requirements
- [x] **README.md**: Complete setup and usage instructions
- [x] **ASSIGNMENT.md**: This grading criteria document
- [x] **Code Comments**: Meaningful comments throughout codebase
- [x] **Project Structure**: Well-organized file and folder structure

---

## 🎯 Bonus Points (Up to 5 Extra Points)

**Optional enhancements that can earn bonus points:**

- [x] **Ultra-Futuristic Styling**: Cyberpunk neon theme with advanced CSS animations and 3D effects (+3 pts)
- [x] **Next-Gen UI/UX**: Holographic cards, neural network backgrounds, and cyber aesthetics (+3 pts)
- [x] **Advanced Typography**: JetBrains Mono integration for cyber terminal feel (+1 pt)
- [ ] **Image Upload**: File upload functionality for character images (+2 pts)
- [ ] **Search/Filter**: Card search and filtering capabilities (+2 pts)
- [ ] **Card Statistics**: Dashboard with collection statistics (+1 pt)
- [ ] **Export Functionality**: Export cards to PDF or other formats (+2 pts)

---

## 📝 Submission Requirements

### What to Submit:
1. **Complete Project Folder**: All source code files
2. **Database Files**: Any .mdf/.ldf files if using LocalDB
3. **Documentation**: README.md and ASSIGNMENT.md files
4. **Screenshots**: Screenshots of the running application

### Submission Format:
- **Compressed File**: ZIP or RAR format
- **Naming Convention**: `PF_LAB3_BSIT32A1_Soriano_Terrance`
- **File Size**: Must be under 50MB (exclude bin/obj folders)

### Deadline:
- **Due Date**: [To be announced by instructor]
- **Late Penalty**: 10% per day late
- **No submissions accepted after 1 week past due date**

---

## 🔍 Testing Checklist for Students

Before submitting, ensure the following works:

### Database Setup
- [ ] Run migrations successfully
- [ ] Database connections work
- [ ] Seed data loads properly

### Authentication
- [ ] User registration works
- [ ] User login/logout works
- [ ] Password validation works
- [ ] Access control is enforced

### CRUD Operations
- [ ] Create new cards
- [ ] View all cards in collection
- [ ] View individual card details
- [ ] Edit existing cards
- [ ] Delete cards with confirmation
- [ ] Authorization prevents editing others' cards

### User Interface
- [ ] All pages load without errors
- [ ] Forms validate input properly
- [ ] Navigation works between all pages
- [ ] Responsive design works on mobile
- [ ] Theme is consistent throughout
- [ ] Icons and styling display correctly

### Error Handling
- [ ] Graceful handling of invalid URLs
- [ ] Proper error messages for validation failures
- [ ] 404 pages for missing cards
- [ ] Database connection error handling

---

## 💡 Tips for Success

### Development Best Practices
1. **Test Early and Often**: Don't wait until the end to test functionality
2. **Follow MVC Patterns**: Keep controllers thin, models focused, views clean
3. **Use Version Control**: Regular commits help track progress
4. **Validate Input**: Always validate user input on both client and server
5. **Handle Errors Gracefully**: Provide meaningful error messages to users

### Common Pitfalls to Avoid
- **Missing Migrations**: Always run migrations after model changes
- **Broken Authentication**: Test login/logout thoroughly
- **Inconsistent Theming**: Apply theme consistently across all pages
- **Poor Validation**: Don't rely only on client-side validation
- **Security Issues**: Never trust user input without validation

### Getting Help
- **Read Documentation**: README.md contains detailed setup instructions
- **Check Error Messages**: Browser developer tools show helpful error info
- **Ask Questions**: Don't hesitate to ask instructor for clarification
- **Peer Discussion**: Collaborate with classmates on concepts (not code)

---

**Good luck with your assignment! 🎮✨**

*Remember: This project should demonstrate your understanding of MVC architecture, database design, user authentication, and web development best practices.*
