Baobab Ridge Wildlife Rehabilitation Records SystemBelgium Campus - Programming 2782 (Project 2026)
====================================================================================================
Group Members:

Bandile Ndlangamandla – 602122




How to Build and RunClone this repository to your local machine:

1. Open the solution file (.sln) in Visual Studio.  
2. Ensure your target framework is set to .NET 8.0. 
3. Verify that animals.txt is in the project directory and its properties are set to "Copy to Output Directory: Copy if newer".
4. Build and run the application (F5 or the Start button). 
5. The application will execute and automatically load the records from the text file.

Features:

1. View Animals: Displays all valid records in a read-only DataGridView upon startup, skipping any malformed lines.
2. Add Animal: Allows users to input new animal records with strict validation for formatting, data types, and required fields. Automatically calculates the Status and Housing Unit based on the inputted Recovery Score.  
3. Update Animal: Load an existing record via grid selection or exact ID search to modify its details. Recalculates the Status and Housing Unit upon saving, modifying only the selected record in the text file.  
4. Delete Animal: Removes a selected animal from the system and the text file following a Yes/No confirmation prompt.   
5. Summary Report: Generates a statistical overview (totals, averages, and status counts) displayed on the form and saved to a local text file.   

File Formats:

1. animals.txt   A UTF-8 encoded plain text file acting as the primary database. It contains no headers and no blank lines. Each record sits on a new line with seven fields separated by the pipe (|) character in the following exact order:
Animal ID | Name | Species | Age | Recovery Score | Status | Housing Unit  
2. summary.txt   An auto-generated text file overwritten each time a user clicks "Generate Summary". 

Known Limitations :

	1. The system relies on a local, plain text file for storage, meaning simultaneous multi-user network editing is not supported. 
	2. The Animal ID search requires an exact match to load a record for updates. 