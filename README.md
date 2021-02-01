# UnitFormation
Arranges UnityGameObjects Into A Stacked Unit Formation
This file has one function called LineFormation which returns a list of Transforms it could return a list of just Vector3 if your game requires it.
The function lays them out to the right and left of a center position with each new row starting at the middle. So if each row has 5 soldiers, and we have 11 soldiers total the formation would have two rows of 5 soldiers and then one soldier centered in the back.

This is a better look for my game personally but this could easily be modified to "dress right" of a squad leader if you wanted

In order for this to work you would need a few things
1. numberInFormation is an int and a parameter for the function to run. It determines the number of units you have/want to lay out in a formation.

2. offset is an float that determines the spacing between units

3. rowInt determines the number of soldiers you want per row, I think odd numbers work best since the algorithm puts soldiers to the right and left of center. 7 for example 3 to the right and 3 to the left and one in the middle. An even number would have 2 on the right and 3 on the left which maybe would'nt look as good.
