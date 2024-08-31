# Medical Image Classification Game

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Usage](#usage)
- [Video Demo](#video-demo)
- [Benefits](#benefits)
- [Tools Used](#tools-used)
- [Requirements](#requirements)


## Introduction
The Medical Image Classification Game is a cross-platform mobile application designed to collect data for deep learning models. The app turns data collection into an engaging experience by allowing medical specialists to classify medical images in a Tinder-like game. As users swipe to classify images, their choices are recorded and sent to a Firebase database for storage. This data is later downloaded for analysis, helping to improve deep learning models. The app is scalable and can be customized to suit different data classification needs.

## Features
- **Gamified Data Collection:** Transforms the classification of medical images into an interactive game, enhancing user engagement.
- **Real-Time Data Synchronization:** Automatically sends classified data to a Firebase database for secure storage.
- **Cross-Platform Compatibility:** Available on both Android and iOS devices, ensuring broad accessibility.
- **Customizable for Various Needs:** The app is scalable and can be adapted to create gamified versions for different types of data classification and database storage.

## Usage
1. **Setup and Installation:**
   - Tweak the parameters of the original app with your own parameters for data classification.
   - Sign in with your credentials to start the classification process.

2. **Playing the Classification Game:**
   - Swipe right to classify an image as positive, and swipe left to classify it as negative (or based on the specific criteria set for the game).
   - Continue swiping through images until the session is complete.

3. **Data Storage:**
   - After classification, the app will automatically send your responses to a Firebase database for storage.

4. **Data Retrieval:**
   - The data stored in Firebase can later be downloaded and analyzed to improve the performance of deep learning models.

## Video Demo
Watch how the Medical Image Classification Game works: [Link to Video Demo](#)

## Benefits
- **Improved Data Collection:** By gamifying the process, the app encourages more consistent and accurate data classification from medical specialists.
- **Scalability:** The app can be customized and scaled to meet the specific needs of different data collection projects.
- **Streamlined Data Management:** With data automatically sent to Firebase, the process of data collection and storage is simplified, making it easier to analyze later.



## Tools Used
- **Unity:** For developing the cross-platform mobile app.
- **Firebase:** For real-time database management and data storage.
- **TensorFlow/Other Deep Learning Libraries:** (Optional) For analyzing the classified data.
- **Google Play Services/Apple Game Center:** For integrating the game-like features on Android and iOS, respectively.

## Requirements
- **Android 8.0 (Oreo) or higher**
- **iOS 11.0 or higher**
- **Unity 2020.3 or higher**
- **Firebase SDK** for real-time database integration



