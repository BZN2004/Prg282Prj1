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

	1. Build the path

	PRG2782 PROJECT - MY CHECKLIST
Baobab Ridge Wildlife Rehabilitation Records System
My part: project foundation, Animal class, classification method, Add feature, file writing
Deadline: submit by 23:59 on 20 October 2026. Presentations 21 and 22 October.

======================================================================
DONE
======================================================================
[x] GitHub repo created, .gitignore and README added, first commit pushed
[x] Default branch is main, old master deleted
[x] Animal.cs written (properties, Classification method, ToFileFormat)
[x] Animal class merged into main with a pull request
[x] Form layout mostly built on my form branch

======================================================================
PART 1: FINISH THE FORM (Visual Studio designer)
======================================================================
Check the status bar (bottom right) shows my form branch, not main.

Summary box (Feature 5.2: results must show on the form)
[ ] Click grpSummary, set Text to "Summary" (it says SummaryBox now)
[ ] Drag Labels INTO the group box. Two labels per line, a caption and a value:
      Caption text          Value label (Name)       Value Text
      Total Animals:        lblTotalAnimals          -
      Average Age:          lblAverageAge            -
      Average Score:        lblAverageScore          -
      Critical:             lblCriticalCount         -
      Serious:              lblSeriousCount          -
      Stable:               lblStableCount           -
      Recovering:           lblRecoveringCount       -
      Release-Ready:        lblReleaseReadyCount     -
[ ] Name the caption labels too, e.g. lblTotalAnimalsCaption
[ ] Move Generate Summary a little inward so it is not on the group box edge



Tidy up
[ ] Select the Name label, Events tab (lightning bolt), clear Click, then
    delete label2_Click in Form1.cs
[ ] View > Tab Order: click ID, Name, Species, Age, Score, Add, press Esc
[ ] Grid Anchor = Top, Left, Right so it does not grow over the lower controls
[ ] Shrink the grid or form so the whole form fits a laptop screen
[ ] Ctrl+K, Ctrl+D to format the code files

Check
[ ] Ctrl+Shift+B (build), then F5 (run). Nothing overlaps or is cut off.

======================================================================
PART 2: COMMIT AND MERGE THE FORM
======================================================================
[ ] Git Changes shows only Form1 files and maybe the .csproj (no bin or obj)
[ ] Commit message: Add search, save, clear and summary controls to form
[ ] Push
[ ] On GitHub open a pull request into main, merge with the DEFAULT merge
    option (do not squash, commits count toward the 15 minimum)
[ ] In Visual Studio switch to main, Git > Pull
[ ] Tell partners: pull main, then branch from it. Agree who edits the
    designer file so nobody gets merge conflicts.
[ ] Agree with the group who writes the shared load method for animals.txt

======================================================================
PART 3: DATA FILE AND LOADING (agree owner with the View person)
======================================================================
[ ] Add animals.txt to the project (Add > New Item > Text File)
[ ] At least 8 valid lines, at least 4 different statuses, format with no
    spaces around the pipes:
      WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp
[ ] No header line, no blank lines, UTF-8
[ ] Properties of animals.txt: Copy to Output Directory = Copy if newer
[ ] Path built with Path.Combine(AppContext.BaseDirectory, "animals.txt")
    (never a C:\Users path)
[ ] If the file is missing, create an empty one, show an empty grid, no error
[ ] Loader skips malformed lines (wrong field count, non-numeric age or
    score, invalid ID), counts them, tells the user once after loading
[ ] Loader returns a List<Animal> used by the grid and the uniqueness check

======================================================================
PART 4: ADD FEATURE VALIDATION (new branch, e.g. AddAnimalValidation)
======================================================================
Trim every box first. Check in form order. On the FIRST failure: show a
message naming the field, call Focus() on that box, return, save nothing.

[ ] Animal ID: required, upper-cased, WR- followed by exactly 4 digits
    (use [0-9], not \d), must be unique
[ ] Name: required, 1 to 30 characters, no pipe character |
[ ] Species: required, 1 to 30 characters, no pipe character |
[ ] Age: whole number 0 to 100 (use int.TryParse, reject decimals and text)
[ ] Recovery Score: whole number 0 to 100 (int.TryParse)
[ ] Put the checks in their own method(s) so btnAdd_Click stays short
Suggested commits (verb first):
      Add validation for animal ID format
      Add uniqueness check for animal ID
      Add validation for name and species
      Add validation for age and recovery score

======================================================================
PART 5: FILE WRITING FOR ADD
======================================================================
[ ] Create the Animal, call Classification()
[ ] Append ONE line (ToFileFormat) to animals.txt, existing lines untouched
[ ] Handle a file that does not end in a newline (no glued lines)
[ ] No blank lines in the file
[ ] File call wrapped in its own try/catch:
      IOException (file in use) and UnauthorizedAccessException (read-only)
      Friendly message, no stack trace, program keeps running
[ ] On success: show the calculated Status and Housing Unit in a message
[ ] Refresh the grid (no duplicate rows), clear the input boxes
[ ] Test: set animals.txt to read-only, and open it in another program
Suggested commits:
      Add append to animals.txt with error handling
      Refresh grid and clear inputs after add

======================================================================
PART 6: QUALITY CHECKS BEFORE EACH PULL REQUEST
======================================================================
[ ] Comment above EVERY method saying what it does
[ ] Inline comment on any logic that is not obvious
[ ] Delete old commented-out code and empty stub handlers nobody uses
[ ] Meaningful names for controls, variables and methods
[ ] Test boundary scores: 0, 19, 20, 39, 40, 59, 60, 79, 80, 100
[ ] Test bad input: blank fields, letters in Age and Score, lowercase ID,
    WR-12345, WR-00A7, duplicate ID, name with a | character
[ ] Build succeeds, then open the pull request into main

======================================================================
GIT RULES FROM THE BRIEF (keep checking)
======================================================================
- At least 15 commits total, 3+ per member, on at least 3 different days
- Commit messages start with a verb and describe the change
- Each feature on its own branch, merged into main via pull request
- Every member owns at least one feature and has a merged pull request
- main must always build. No force-push. Do not commit bin, obj, .vs, summary.txt
- user.name and user.email set correctly so commits show under my name
- README.md: project name, all member names and student numbers, how to build
  and run, list of features, short description of both file formats, known
  limitations
- Repo public, or private with the lecturer added as a collaborator
- Everything pushed, GitHub main matches local main

======================================================================
BEFORE SUBMISSION (by 23:59, 20 October)
======================================================================
[ ] Clone the repo into a NEW empty folder, build it, run it, all five
    features work
[ ] Starter animals.txt appears beside the .exe after a build
[ ] README complete, every member has commits and a merged pull request
[ ] Lecturer added as collaborator (if private)
[ ] Submit the GitHub URL and a zip of the whole project on BCConnect

======================================================================
FOR THE PRESENTATION (20 minutes + 5 minutes questions)
======================================================================
[ ] Be able to explain, in my own words: the Animal class, the single
    Classification method (why it is in one place), validation order, how
    the file is appended, how errors are handled
[ ] Know the answers to: how an Animal is built from a file line, why
    Status and HousingUnit have private set, what protects Classification
    from out-of-range scores
[ ] Practise a live test: add an animal with score 79, then 80, and predict
    the status before clicking
[ ] Show commits, branches and my pull request on GitHub
[ ] Every member presents at least 3 minutes
