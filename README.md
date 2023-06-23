# The "RPS" Game By TripleFlacko

A console-based C# implementation of the "Rock - Paper - Scissors" game.

<img alt="RPS Picture" width="525px" src="https://media.istockphoto.com/id/1395632555/vector/colorful-hand-icon-set.jpg?s=612x612&w=0&k=20&c=g6r4Oms6euKipRCjlwLx-8MPs1pajjnP4_aK0r6HEeo=">

<a href="https://github.com/TripleFlacko/RPS-GameByTripleFlacko/blob/main/RPS%20Game/RPS-Game.cs">RPS</a> is a simple two player game, where you and your oponent (the computer) simultaneously choose one of the following three options: "**rock**", "**paper**" or "**scissors**". The rules are as follows:
* **Rock beats scissors** (the scissors get broken by the rock)
* **Scissors beats paper** (the paper get cut by the scissors)
* **Paper beats rock** (the paper covers the rock)

The **winner** is the player whose choice beats the choice of his oponent. If both players choose the same option (e.g. "paper"), the game outcome is "**draw**".

## Input and Output

The player enters one of the following options:

* `rock` or `r`
* `paper` or `p`
* `scissors` or `s`

The input is not case-sensitive. The computer chooses a **random option**, then reveals the **winner** and show the score table.

Afterwards the player is given the option to either play again or quit the game by typing the following options:

* `yes` or `y` (play again)
* `no` or `n` (quit the game)

## Solution

<table>
  <tr>
    <th>You</th>
    <th>Computer</th>
    <th>Outcome</th>
  </tr>
  <tr>
    <td>rock</td>
    <td>rock</td>
    <td>Draw</td>
  </tr>
  <tr>
    <td>rock</td>
    <td>paper</td>
    <td>You lose</td>
  </tr>
    <tr>
    <td>rock</td>
    <td>scissors</td>
    <td>You win</td>
  </tr>
    <tr>
    <td>paper</td>
    <td>rock</td>
    <td>You win</td>
  </tr>
    <tr>
    <td>paper</td>
    <td>paper</td>
    <td>Draw</td>
  </tr>
    <tr>
    <td>paper</td>
    <td>scissors</td>
    <td>You lose</td>
  </tr>
    <tr>
    <td>scissors</td>
    <td>rock</td>
    <td>You lose</td>
  </tr>
    <tr>
    <td>scissors</td>
    <td>paper</td>
    <td>You win</td>
  </tr>
    <tr>
    <td>scissors</td>
    <td>scissors</td>
    <td>Draw</td>
  </tr>
</table>

We handle all these situations using a series of checks.

## Source Code

[Click here to open the file](RPS-Game.cs)

## Screenshots


![1](https://github.com/TripleFlacko/RPS-GameByTripleFlacko/assets/119543923/5ba1c2c8-8ec2-4acb-9065-8da306776584)



![2](https://github.com/TripleFlacko/RPS-GameByTripleFlacko/assets/119543923/25bf2a4f-0085-4131-a8ec-8e1b95c9b981)



![Screenshot 2023-05-23 141311](https://github.com/TripleFlacko/RPS-GameByTripleFlacko/assets/119543923/ad01152a-7b00-4e7a-93cd-00d20a2af8f1)



## Live Demo

You can play the game directly in your Web browser <a href="https://replit.com/@TripleFlacko/RPS-Game-By-TripleFlacko">here</a>:

<div>
  <a href="https://replit.com/@TripleFlacko/RPS-Game-By-TripleFlacko"><img src="https://raw.githubusercontent.com/TripleFlacko/RPS-Game-By-TripleFlacko/main/live-preview.png" alt="Play Button"></a>
</div>
