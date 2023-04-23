# Laboratory-work-5-SFU-1st-year-2nd-semester
#This is a laboratory work project, in which it is necessary to describe the operation of a simple patient record system on Winforms.

#The Model project is responsible for the internal operation of the system and is referenced by the Logic controller. 
The form refers to Logic and its objects.

#A little bit about architecture.
Patient data is read and processed from some Excel spreadsheet. The model notifies Logic of changes to its lists, and the form checks for Logic events. (Hopefully, this architecture will even be extensible.)
