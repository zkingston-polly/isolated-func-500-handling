This project demonstrates an apparent regression with azure func host (or maybe the zure function core tools).

Steps to produce the error:
- Install Azure Function Core Tools version 4.0.5611 (function runtime 4.31.1.22191)
- Install Azure Function Core Tools version 4.0.5801 (function runtime 4.34.1.22669)

Run the project with tools version 4.0.5611
```
/4.0.5611/func.exe start
```
Hit the test endpoint
```
curl http://localhost:7071/api/test
```
A 500 error is returned.

Now run the project with tools version 4.0.5801
```
/4.0.5801/func.exe start
```
Hit the test endpoint
```
curl http://localhost:7071/api/test
```
The request hangs, a timeout error eventually occurs.

Expected result: A 500 error is returned regardless of which version of the core tools is being used.
