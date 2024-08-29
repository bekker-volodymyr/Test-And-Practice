# Guide

<h2>DOTween</h2>
 <p>
  To practice using DOTween, I followed <a href="https://www.youtube.com/watch?v=oZh2Hgzrrqk">this tutorial</a>. I created several animations for movement and rotation with looping and easing, using individual tweens and building sequences with the Append and Join methods. Demo below:
 </p>
 <img src="https://github.com/user-attachments/assets/71b0d4f7-7414-44ef-a48b-4573aaca082d" alt="Demo for DOTween animations">

<h2>Zenject</h2>
 <p>
  To learn how to work with the Zenject framework, I created a specific folder and scene. For my first exploration of the framework, I followed a YouTube tutorial (<a href="https://www.youtube.com/watch?v=gqEhy8nS3fk">link</a>). 
 <br>
  As an example, I decided to create a logger interface with a Log(string message) method and two concrete loggers: DebugLogger, which writes data to the Debug console, and TMPLogger, which writes data to a TextMeshPro object with a specific tag.
 <br>
  The logger dependency is injected into a Messenger class, which logs a simple message in the Start method. 
 <br>
  I tested injection into fields, properties, and methods and learned the order in which these injections occur. I also experimented with injection using an Id.
 <br>
  I plan to extend this Zenject implementation as I dive deeper into the framework.
 </p>
