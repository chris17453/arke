# Arke is a configurable webAPI
### arke uses dynamic routing for testing and execution.


## How does it do it
With dynamic routing and type mapping. 
When a request is received its's arguments are transformed and passed to the 
target. The request waits for a result and passes that result as transformed 
JSON.


## It's all about the route.
### Routes contain:
- input map 
- output map
- live target 
- test target
### Targets:
- Can be a static file or an executable script
### Maps:
- Convert WebAPI JSON into parameters for scripts 


## Software design
The point of arke is to allow diverse scripts to act in concert without the need 
for building an API. The backend scripts can be API agnostic. Front end 
development can occur silmutaniosly with a working api that uses stubs.  Routes 
are easily created and destroyed. Route stubs can be scripted or static. This is 
great for testing.


## Configuration
ark was designed as a simple service. All configuration is done via text files.
- configuration is text based
- All Routes are stored in a text file.

## Arke's namesake
ARKE (Arce) was the messenger of the Titan-gods and sister of the 
rainbow-goddess Iris. During the Titan War the two goddesses served on 
opposite sides--Iris became the messenger of the Olympian Gods and Arke 
assumed the role of messenger of the Titanes. 




~fin