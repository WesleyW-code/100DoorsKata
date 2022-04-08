# 100DoorsKata

I completed the below challenge and added units tests for possible cases using Nunit.Framework!

## Below is the description of the challenge:

### The Kata
There are 100 doors in a row that are all closed. You make 100 passes through the doors. With each pass you toggle
the doors state. On each pass you visit the Nth door. That is on the first pass you visit every door. On the second pass
you visit every 2nd door. On the third pass you visit every 3rd door and so on until you complete the 100th pass.

● The first pass you visit every door and open it.

● The second pass you visit only every second door (#2, #4, #6, …) and close them as you visit.

● The third pass you visit every 3rd door (#3, #6, #9, …) toggling the door’s state. If the door is closed you open it, it if is open you close it.

● Continue until you complete the 100th pass only visiting the 100th door.

After 100 passes what is the state of each door?
Print which doors are open and which are closed as a single string.
Use @ for an open door and # for a closed door.

#### Examples
The first six doors could look something like this : @@##@@##

#### Bonus
Add a third state of holding (use H). By adding this state, you must toggle between open, holding and closed when
visiting the doors.
 
