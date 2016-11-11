rem https://github.com/swagger-api/swagger-codegen
rem java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar help generate
java -jar modules\swagger-codegen-cli\target\swagger-codegen-cli.jar generate -i https://api.reepay.com/swagger.json -l csharp -o c:\ReepayApi\reepay_api_client)
pause