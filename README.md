# Data collection interface
## Introduction
Usually, both the planning of a data collection and the evaluation of the collected data is done in a software.
The data collection however is often executed by humans, which brings along issues in data transmission.
A data collection software can assist by
* simplifying the data entry by recording data directly in an electronic form
    * either by typing
    * and/or using a voice interface like smatrix
* taking care of the transmission 
    * to import the information on what data has to be collected
    * to report the collected data back to the originating software for evaluation
For these transmissions we require an interface, which is described in the following

## Scope
The interface contains
* information on what data has to be collected
* information on supported value ranges for the data
* the collected data itself (after the collection)
* information for localization and speech enabled applications

## Background
This interface was created in the context of agroscience.
Regardless of this background, the interface is kept generic to cover different use cases in agroscience or even other fields of work. 
In agroscience, research trials are executed e.g., to evaluate agrochemicals such as fertilizer, growth regulators, fungicides/herbicides/insecticides or in the context of breeding of new plant and seeds varieties.
Data for these trials is then collected by field technicians, by rating certain traits.
By using smatrix, the field technicians can keep their hands and eyes free to focus on data collection.

## Make it generic
To yield a generic interface, the information needs to be abstracted.
That is possible, because the data collection software doesn't need to interpret the information - the user takes care of that.
E.g., the software doesn't need to know what trees, plants or cars are - the user knows what these words mean.

The data collection software only needs to know what to do with this information (e.g. display).
It can be achieved by using abstract blocks of information in a predefined format.
* their content is dependent on the use case and will be interpreted by the user
* additional flags in these blocks indicate how the information blocks can be used by the data collection software

## How does that work?
In the simplest use case it boils down to defining rows and columns of a table, where
* the rows represent the objects that are assessed
* the columns define the characteristics that need to be assessed for each object

### Notes
* For further information please have a look at the detailed documentation in doc/DataCollectionInterface.pdf
* Class definitions for json serialization/deserialization in C# are provided.
    * Note that this code uses nuget package Newtonsoft.Json