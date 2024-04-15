// Define the pins for the LEDs and temperature sensor
const int ledPin1 = 3;
const int ledPin2 = 2;
const int ledPin3 = 1;
const int tempSensorPin = A1;

// Variables to store temperature and LED status
int temperature = 0;
int baseTemperature = 40; // Set the base temperature here

void setup() {
  // Set the LED pins as output
  pinMode(ledPin1, OUTPUT);
  pinMode(ledPin2, OUTPUT);
  pinMode(ledPin3, OUTPUT);
}

void loop() {
  // Read the temperature from the analog pin
  int rawTemperature = analogRead(tempSensorPin);

  // Convert the temperature to Celsius
  float celsius = convertToCelsius(rawTemperature);

  // Check if the temperature is above the base temperature
  if (celsius > baseTemperature) {
    // Check temperature thresholds and turn on respective LEDs
    if (celsius >= 30 && celsius < 70) {
      digitalWrite(ledPin1, HIGH);
      digitalWrite(ledPin2, LOW);
      digitalWrite(ledPin3, LOW);
    } else if (celsius >= 70 && celsius < 120) {
      digitalWrite(ledPin1, HIGH);
      digitalWrite(ledPin2, HIGH);
      digitalWrite(ledPin3, LOW);
    } else if (celsius >= 120) {
      digitalWrite(ledPin1, HIGH);
      digitalWrite(ledPin2, HIGH);
      digitalWrite(ledPin3, HIGH);
    } else {
      digitalWrite(ledPin1, LOW);
      digitalWrite(ledPin2, LOW);
      digitalWrite(ledPin3, LOW);
    }
  } else {
    digitalWrite(ledPin1, LOW);
    digitalWrite(ledPin2, LOW);
    digitalWrite(ledPin3, LOW);
  }

  // Delay for a short period of time before reading the temperature again
  delay(100);
}

float convertToCelsius(int rawTemperature) {
  // Convert the raw temperature reading to Celsius
  float voltage = rawTemperature * 5.0 / 1023.0;
  float celsius = (voltage - 0.5) * 100.0;

  return celsius;
}