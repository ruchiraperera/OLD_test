FilterTypes
--------------------------

01, Authorized filters - run first and check whether the user is authorized for the request

02, Resource Filters - run after authorization and model binding (onResourceExecting , OnResourceExecuted)

03, Action Filters - run before and after action method is called

04, Exception Filters - apply global policies to unhandled exceptions before the response has been written

05, Result Filters - run code immediately before and after execution of action results


