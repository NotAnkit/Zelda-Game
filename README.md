# Zelda-Game

This Repository is for Team Alpha Won in CSE 3902 recreating the first dungen from the orginal Legend of Zelda Game. This project will take four sprints to complete to add all the functionallity. 

## V1

#### Controls

Controls | Function
| :--- | :---:
WASD or Arrow Keys  | to move Link around the screen.
  Z or N | to for Link to use the sword. 
  1 | to use Bomb Item
  2 | to use Blue Arrow
  3 | to use Green Arrow
  4 | to use Fire 
  5 | to use Green Boomerang
  6 | to use Blue Boomerang 
  T and Y | to cycle through blocks
  U and I | to cycle through items
  O and P | to cycle through enemies
  Q | to quit
  R | to Reset
  
#### Bugs
  The project currently only allows for one item to be used at a time, such as only one arrow. Link can also chnage items mid animation, meaning the animations do not complete. When Link uses sword looking up or to the left, link moves back as the animation starts in the top left cornor of link. Link can move across the screen without animation due to the high number of frames and low number of animation frames. Currently the game is stuck on 60 frames for everything, would be better it was adjustable. 

#### Code Metrics

   - Week 1: 256 Stylistic Recomendations
   - Week 2: 683 Stylistic Recomendations
   - Week 3: 127 Stylistic Recomendations
   
  IDE0045: Convert to conditional expression
  dotnet_style_prefer_conditional_expression_over_assignment = false
  - Suppressed because doing math in if statement reduces complexity

  IDE0044: Add readonly modifier
  dotnet_style_readonly_field = false
  - Supressed because unknown whether need to be able to modify in the future

  IDE0090: Use 'new(...)'
  dotnet_diagnostic.IDE0090.severity = none
  - Supressed because breaks code if not intialized correctly

  IDE0011: Add braces
  dotnet_diagnostic.IDE0011.severity = none
  - Suppressed because doing math in if statement reduces complexity and clean code

  IDE0058: Expression value is never used
  dotnet_diagnostic.IDE0058.severity = none
  - Suppressed because not usable yet

  IDE0028: Simplify collection initialization
  dotnet_diagnostic.IDE0028.severity = none
  - Supressed because breaks code if not intialized correctly

  IDE0055: Fix formatting
  dotnet_diagnostic.IDE0055.severity = none
  - Suppressed because doing math in if statement reduces complexity

  IDE0052: Remove unread private members
  dotnet_diagnostic.IDE0052.severity = none
   - Supressed because unknown whether need to be able to modify in the future
