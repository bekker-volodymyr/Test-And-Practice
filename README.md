# Guide

<h2>Unit Testing</h2>
 <p>
  To learn how to use <b>Unit Tests</b>, I followed <a href="https://youtu.be/qCghhGLUa-Y?si=S68QxovtaIDjPuL8">tutorial</a> by Jason Weimann on YouTube. 
 </p>
 <p>
  I practiced creating Edit Mode tests for non-MonoBehaviour classes. For example, I created a class that calculates damage mitigation and wrote unit tests for it.
 </p>
 <p>
  I also developed an Inventory class that tracks items equipped to character parts. The unit tests for this class verify that an item can only be equipped to a part once and that the Inventory object sends a message to the Character object when an item is equipped. 
 </p>
 <p>
  Additionally, I learned how to create Play Mode tests to test MonoBehaviour classes. I implemented a player class and wrote unit tests to check if the player changes position in response to horizontal input. <br>
 </p>
 <p>
  I also explored using the <b>NSubstitute</b> library to mock various objects in several examples. <br>
 </p>

  <img src="https://github.com/user-attachments/assets/be9c11ec-f16b-415a-9146-47a3e45a42d8" width="400px">
  <img src="https://github.com/user-attachments/assets/985fa0ca-d2ad-4dd6-bf21-02ed13c7baee" width="400px">

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
