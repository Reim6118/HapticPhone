#include <WiFi.h>

// Replace these with your WiFi network's SSID and password
// const char *ssid = "lalalalala";
// const char *password = "lalalala";
const char *ssid = "km13307-102";
const char *password = "e2p57ci1w";
char zero ='0';
char one ='1';
// Create a server object
WiFiServer server(6118);  // Use port 23 for the server

void setup() {
  Serial.begin(115200);
  pinMode(2, OUTPUT); 
  pinMode(3, OUTPUT); 
  pinMode(4, OUTPUT); 
  pinMode(5, OUTPUT); 
  pinMode(6, OUTPUT); 
  digitalWrite(2, LOW);
  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  digitalWrite(6, LOW);
  // Connect to WiFi network
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.println("Connecting to WiFi..");
  }
  Serial.println("Connected to the WiFi network");

  // Start the server
  server.begin();
  Serial.println("Server started");

  // Print the IP address
  Serial.println(WiFi.localIP());
}

void loop() {
  // Check if there are any new clients
  WiFiClient client = server.available();
  if (client) {
 
    while (client.connected()) {
 
      while (client.available()>0) {

        String c = client.readStringUntil('\n');
        activate(c);
        Serial.print(c);
      }
 
      
    }
 
    client.stop();
    Serial.println("Client disconnected");
 
  }
}

void activate(String hapticArray)
{
  if (hapticArray[0] == one)
  {
    Serial.print("1");
    digitalWrite(2, HIGH);
    // delay(200);
    // digitalWrite(2,LOW);
  }
  else{Serial.print(0);digitalWrite(2, LOW);}

  if (hapticArray[1] == one)
  {
    Serial.print("1");
    digitalWrite(3, HIGH);
    // delay(200);
    // digitalWrite(3,LOW);
  }
  else{Serial.print(0);digitalWrite(3, LOW);}

  if (hapticArray[2] == one)
  {
    Serial.print("1");
    digitalWrite(4, HIGH);
    // delay(200);
    // digitalWrite(4,LOW);
  }
  else{Serial.print(0);digitalWrite(4, LOW);}

  if (hapticArray[3] == one)
  {
    Serial.print("1");
    digitalWrite(5, HIGH);
    // delay(200);
    // digitalWrite(5,LOW);
  }
  else{Serial.print(0);digitalWrite(5, LOW);}

  if (hapticArray[4] == one)
  {
    Serial.print("1");
    digitalWrite(6, HIGH);
    // delay(200);
    // digitalWrite(6,LOW);
  }
  else{Serial.print("in here");digitalWrite(6, LOW);}

}
