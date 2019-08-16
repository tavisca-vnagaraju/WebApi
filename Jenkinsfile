pipeline {
    agent any
    parameters 
    {
        string(name: 'PROJECT_NAME', defaultValue: 'WebApi')
    }
    environment
    {
        projectToBePublished = '$env:PROJECT_NAME'
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build -p:configuration=release -v:n')
            }
        }
        stage('Test'){
          steps  {
                powershell(script: 'dotnet test')
          }
       }
       stage('Publish'){
          steps  {
                powershell(script: 'dotnet publish $env:projectToBePublished -c Release -o publish')
          }
       }
       stage('Archive')
        {
            steps
            {
              powershell(script: 'docker build -t webapiimage .')   
            }
        }
    }
    post{
        success{
            powershell(script: 'docker run  -p 8979:80  webapiimage .')
        }
    }
}
