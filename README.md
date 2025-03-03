# Getting Started

## Prerequisites

- **Visual Studio 2022**
- **.NET SDK** (compatible with Umbraco version)

## Setup Instructions

### Clone the Repository
```sh
git clone <repository-url>
```

### Extract Database and Media Files
Unzip `umbraco.zip` into the root directory. This contains the SQLite database and media files.

### Open the Project
Use **Visual Studio 2022** to open the project.

### Run the Application
Start the project in **Visual Studio 2022**.

## Website Overview

The website consists of the following pages:
- **General Page**
- **Contact Us**

## Configuration in Backoffice

### Access the Umbraco Backoffice
- **URL:** [https://localhost:44381/umbraco](https://localhost:44381/umbraco)
- **Login Credentials:**
  - **Username:** leeshans06@gmail.com
  - **Password:** Thebadauthcode01!

## Updating Page Content

### General Page Updates:
1. Navigate to the **Content** tab.
2. Select **'General'** under the **Site** section.
3. Choose one of the following blocks:
   - **PageHeader** - `HeroBlock`
   - **MainContent** - `RTEBlockEditorLabel`
4. Edit the selected block as needed.

### Contact Us Updates:
1. Navigate to the **Content** tab.
2. Select **'Contact Us'** under the **Site** section.
3. Choose one of the following blocks:
   - **PageHeader** - `HeroCTABlock`
   - **MainContent** - `RTEBlockEditorLabel`
4. Edit the selected block as needed.

## Notes
- Ensure all changes are **published** in the backoffice for them to reflect on the site.
- The **SQLite database and media files** must be properly extracted for the project to function correctly.
