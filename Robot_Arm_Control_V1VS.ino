//#include "Arduino.h"
#include "Servo.h"
Servo joint_1;
Servo joint_2;
Servo joint_3;
Servo joint_4;
Servo joint_5;
Servo joint_6;
Servo end_effector;
Servo dispenser;
Servo servos[] = {joint_1, joint_2, joint_3, joint_4, joint_5, joint_6, end_effector, dispenser};
volatile int servopins[] = {2,3,4,5,6,7,8,9};
int servopos[] = {0, 0, 0, 0 ,0, 0, 0, 0};
volatile int calibration[] = {0, 0, 0, 0, 0, 0, 0, 0};//change
volatile int neutralpos[] = {40, 50, 60, 70, 80, 90};//update
//Pots
volatile int potpins[] = {A0, A1, A2, A3, A4, A5, A6, A7};
int potpos[] = {0, 0, 0, 0, 0, 0, 0, 0};
int lastpotpos[] = {0, 0, 0, 0, 0, 0, 0, 0};
volatile int minservopos[] = {0};
//Mode Switch
int modeswitchpin = 22;//change
//Plow
int enablePin = 11;//pwm change later 
int in1Pin = 10;//pwm change later
int in2Pin = 9;//pwm change later
void setup()
{
  Serial.begin(9600);
//Servo init
  for(unsigned int i = 0;i < 8;i++){
    servos[i].attach(servopins[i]);
  }
//Plow
   pinMode(in1Pin, OUTPUT);
   pinMode(in2Pin, OUTPUT);
   pinMode(enablePin, OUTPUT);
}

// The loop function is called in an endless loop
void loop()
{
  //if(digitalRead(modeswitchpin) == HIGH){
  unsigned long currentMillis = millis();
  long previousMillis = 0;
    if(currentMillis - previousMillis > 15){
      previousMillis = currentMillis;
        updatemovement(true); 
    } 
  //}else{
    //goToNeutralPos(false);   
  //}
}
///////////////////////////////////////////////////////////////////////////////////////////////////
void updatemovement(boolean debug){
  for(int i = 0;i < 8;i++){
      potpos[i] = analogRead(potpins[i]);//reads pots
      //if(potpos[i]-lastpotpos[i] > 5){//removes jitter
        servopos[i] = map(potpos[i],0,1023,0,180);//converts pot value to pwm value
        servos[i].write(servopos[i]);//moves servos plus the offset
        //lastpotpos[i] = potpos[i];//updates last pos
      //}
    }
    if(debug == true){//Debugging in serial monitor
      //Serial.println("Servos: ");
      Serial.print("a");
      Serial.print(servopos[0]);
      Serial.print("b");
      Serial.print(servopos[1]);
      Serial.print("c");
      Serial.print(servopos[2]);
      Serial.print("d");
      Serial.print(servopos[3]);
      Serial.print("e");
      Serial.print(servopos[4]);
      Serial.print("f");
      Serial.print(servopos[5]);
      Serial.print("gh");
      delay(100);
      //Serial.println(");
      
    /*
      for(int y = 0;y < 6;y++){
        Serial.print(servopos[y]);
        Serial.print(" ");
      }
      Serial.println(""); 
      */
    }
    
}
///////////////////////////////////////////////////////////////////////////////////////
void goToNeutralPos(boolean debug){
  for(int i = 0;i < 6;i++){//Go to neutral pos
    servos[i].write(neutralpos[i]);//Neutral pos will be upright like in competetion to get bonus
  }

  if(debug == true){
    Serial.print(servopos[0]);
    Serial.print("n");
      //Serial.println("Servos: ");//Debug to check if it gets to the right pos
      /*
      for(int y = 0;y < 6;y++){
        Serial.print(servopos[y]);
        Serial.print(" ");
        //backSpace(getLength(servopos[y]));
      }
      */
      
      //Serial.println(""); 
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////
void plow(){
  setMotor(255, true);
}
//////////////////////////////////////////////////////////////////////////////////////////////////
void setMotor(int speed, boolean reverse)
{
  analogWrite(enablePin, speed);
  digitalWrite(in1Pin, ! reverse);
  digitalWrite(in2Pin, reverse);
}
/////////////////////////////////////////////////////////////////////////////////////////////////
