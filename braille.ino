/*
 Controlling a servo position using a potentiometer (variable resistor)
 by Michal Rinott <http://people.interaction-ivrea.it/m.rinott>

 modified on 8 Nov 2013
 by Scott Fitzgerald
 http://www.arduino.cc/en/Tutorial/Knob
*/

#include <Servo.h>

#define UP 180
#define DOWN 20

#define G A0
#define R A1
#define B A2

Servo servo_1;
Servo servo_2;
Servo servo_3;
Servo servo_4;
Servo servo_5;
Servo servo_6;

int Rvalue = 254, Gvalue = 1, Bvalue = 127;;
int Rdirection = -1, Gdirection = 1, Bdirection = -1;

int val;    

void setup() {
  Serial.begin(9600);

  setLed(0, 0, 0);
  
  servo_1.attach(2); 
  servo_2.attach(3); 
  servo_3.attach(4); 
  servo_4.attach(5); 
  servo_5.attach(6); 
  servo_6.attach(7); 

  changeMotors("000000");
}

void loop() { 
  analogWrite(R, Rvalue);       // write analog signal
  analogWrite(G, Gvalue);
  analogWrite(B, Bvalue);

  Rvalue = Rvalue + Rdirection;   //changing values of LEDs
  Gvalue = Gvalue + Gdirection;
  Bvalue = Bvalue + Bdirection;

  //now change direction for each color if it reaches 255
  if (Rvalue >= 255 || Rvalue <= 0)
  {
    Rdirection = Rdirection * -1;
  }
  if (Gvalue >= 255 || Gvalue <= 0)
  {
    Gdirection = Rdirection * -1;
  }
  if (Bvalue >= 255 || Bvalue <= 0)
  {
    Bdirection = Bdirection * -1;
  }
  delay(10);    //give some delay so you can see the change            
}

void setLed(int g, int r, int b) {
  analogWrite(G, g);
  analogWrite(R, r);
  analogWrite(B, b);
}

String inputString = "";

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    if (inChar == '\n') {
       changeMotors(inputString);
       inputString = "";
      return;
    }
    inputString += inChar;
  }
}

void changeMotors(String input) {
  Serial.println(input.charAt(0));
  servo_1.write(input.charAt(0) == '1' ? UP : DOWN);
  servo_2.write(input.charAt(1) == '1' ? UP : DOWN);
  servo_3.write(input.charAt(2) == '1' ? UP : DOWN);
  servo_4.write(input.charAt(3) == '1' ? UP : DOWN);
  servo_5.write(input.charAt(4) == '1' ? UP : DOWN);
  servo_6.write(input.charAt(5) == '1' ? UP : DOWN);
}
