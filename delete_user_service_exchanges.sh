for q in UserService UserService.IT-V-2S874JG8WP UserService.Retries UserService.Timeouts UserService.TimeoutsDispatcher 
do 
    python /c/Users/larryj/professional/software/devtools/rabbitmq/rabbitmqadmin delete exchange name=$q
done
