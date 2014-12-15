#Ultimate TicTacToe
-----------------------------------------------------------------
- Ultimate TicTacToe is just like normal TicTacToe. Just kidding. It is actually ultimate.
- When 9 TicTacToe boards make another TicTacToe board, it becomes the Ultimate TicTacToe. It looks something like this:
  ![Initial Screen] (http://i.imgur.com/mqxlAxG.png)
- Without any further ado, let's get right into it!

######Basic rules of the game:
1. As shown above, the game begins with 81 squares from 9 separate, smaller(original) TicTacToe boards.
2. The player who places first can place in any square of the 81 squares. He selects a grid and places in his choice.
3. From the second move, each player should place corresponding to the previous move.
  - Correspondence: The square in first row and second column in every small grid is in correspondace with the grid in
    the first row and second column in the main grid. This can be shown like this:
    ![Grid with its corresponding squares] (http://i.imgur.com/QIPbn6d.png)
    The squares circled with smaller circles and the grid circled with the bigger circle are in correspondence.
  
  - When a player places in any of the sqaures with smaller circles around it, the next player should place in the grid
    with bigger circle around it.
    
    **Illustration**: The first player chooses the grid in second row and second column.
    ![Grid chosen by first player is selected] (http://i.imgur.com/Dp4sOk9.png)
    He places his symbol('O' in this case) in the square in second row, third column.
    ![Control shifts to the corresponding grid] (http://i.imgur.com/FfUySmI.png)
    The next player should place in the grid pointed by the blue colored box only. So, the next player chooses to place
    in one of the squares in the grid pointed by the blue box. Player X plays in the grid led to by Player O and leads Player O to the corresponding grid and this continues.
    ![Player X plays in the corresponding grid] (http://i.imgur.com/kdg86Ph.png)

4. If a row or a column or a diagonal in a grid contains the same symbol, then that grid is won the player of that
  symbol.
   Consider a situation where the grid is like this:
    ![One move and O wins 2x2] (http://i.imgur.com/eqp7JVN.png)
    If X places in the second square in the second row, then O's turn is in the second grid of second row.
    Then there are three rows in the last column in the second grid of the second row:
    ![O's certain win] (http://i.imgur.com/ADaIVQv.png)
    If Player O plays in the third square of third row in the current grid, then **Player O wins in second grid of second row!**
    ![PLayer O wins in second grid of second row] (http://i.imgur.com/wWjJHEZ.png)

5. If a player sends the next player to the grid that is already won, then the other player has the freedom of choosing any grid of his choice, among the grids that are not won yet.
    If the Player X plays in the second square of second row in third grid of third row, where it currently is, then the Player O should play in the second grid of second row, which is already won by Player O. Hence, Player O now has the liberty to choose from any of the grids that are not won yet.
    ![X sends O to grid won by O] (http://i.imgur.com/GoofKVd.png)

6. A player wins the game if the grids in a row or a column or a diagonal are won by the player, before the other player.
    If the Player O now plays in first square of third row in third grid of second row, then he wins!
    ![O is already there] (http://i.imgur.com/EgCV6fQ.png)
    And hence, O wins the game!
    ![O wins the game] (http://i.imgur.com/tRoHWJV.png)

7. If the whole grid is full and no player has three wins in a column or a row or a diagonal, then the game is a draw.

######Advantages over classic TicTacToe:
- In the original TicTacToe, the game is always a draw if both the players are well versed with the game. That is not the case in the Ultimate TicTacToe.
- The original TicTacToe has no strategy. There is only one way to play. Ultimate TicTacToe is way more strategic. The player should think before playing whether it leads the other player to the square that is advantageous to that player.


######Some additional screenshots from the game:
![Scene 1] (http://i.imgur.com/A7oYakJ.png)
![Scene 2] (http://i.imgur.com/8UzE5uI.png)
![The Tie Scene] (http://i.imgur.com/6Bt6Qib.png)
