echo Clean up UserService
echo

USER_SERVICE_OBJECTS="UserService UserService.IT-V-2S874JG8WP UserService.Retries UserService.Timeouts UserService.TimeoutsDispatcher"

for q in $USER_SERVICE_OBJECTS
do 
    echo Deleting exchange $q
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete exchange name=$q
done

for q in $USER_SERVICE_OBJECTS
do 
    echo Deleting queue $q
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete queue name=$q
done

echo Clean up ExampleWeb
echo

EXAMPLE_WEB_OBJECTS="ExampleWeb ExampleWeb.IT-V-2S874JG8WP ExampleWeb.Retries ExampleWeb.Timeouts ExampleWeb.TimeoutsDispatcher"

for q in $EXAMPLE_WEB_OBJECTS
do 
    echo Deleting exchange $q
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete exchange name=$q
done

for q in $EXAMPLE_WEB_OBJECTS
do 
    echo Deleting queue $q
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete queue name=$q
done

echo Clean up Welcome Email Service
echo

WELCOME_EMAIL_SERVICE_OBJECTS="WelcomeEmailService WelcomeEmailService.IT-V-2S874JG8WP WelcomeEmailService.Retries WelcomeEmailService.Timeouts WelcomeEmailService.TimeoutsDispatcher"

for q in $WELCOME_EMAIL_SERVICE_OBJECTS
do 
    echo Deleting exchange $q
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete exchange name=$q
done

for q in $WELCOME_EMAIL_SERVICE_OBJECTS
do 
    echo Deleting queue $q
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete queue name=$q
done
