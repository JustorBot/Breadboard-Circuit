// Pin numbers for each color of the RGB LED
const int redPin = 9;
const int greenPin = 10;
const int bluePin = 11;

// Function to set the color of the RGB LED
void setRGBColor(int red, int green, int blue) {
  analogWrite(redPin, red);
  analogWrite(greenPin, green);
  analogWrite(bluePin, blue);
}

void setup() {
  // Set pin modes for each color of the RGB LED
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
}

void loop() {
  // Infinite loop
  while (true) {
    // Set RGB color to red
    setRGBColor(255, 0, 0);
    delay(1000); 

    // Set RGB color to green
    setRGBColor(0, 255, 0);
    delay(1000);

    // Set RGB color to blue
    setRGBColor(0, 0, 255);
    delay(1000);
  }
}