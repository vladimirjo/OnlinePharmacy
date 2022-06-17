# Online Pharmacy - an CRUD web application build with ASP.NET

# Description
- MVC for Home Page
- Razor Pages for Shopping Cart Page
- Bootstrap for UI and Font Awesome for icons
- MSSql as database 
- Blazor for Administration

In this Solutions there are 2 Projects:
1. OnlinePharmacy - Demo web application with CRUD functionality. 
2. OnlinePharmacy.Test - Unit and Integration Tests for Online Pharmacy

# Installation

This webapp is dockerized and to use is you have to have installed Docker.

clone repository: `git clone git@github.com:vladimirjo/OnlinePharmacy.git`
change to webapp directory: `cd .\OnlinePharmacy\OnlinePharmacy\`
compile webapp: `dotnet publish -c Release`
build docker images: `docker-compose build`
run MSSql container: `docker-compose up sqlserver`
run webapp container in another terminal after the MSSql container is running: `docker-compose up onlinepharmacy`

# Usage
open `http://localhost:5000/` in your browser
to visit admin page open: `http://localhost:5000/admin` and use `Admin` and `Secret123$` ase login credentials 