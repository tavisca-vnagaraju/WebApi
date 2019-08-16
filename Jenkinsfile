pipeline {
    agent any
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
                powershell(script: 'dotnet publish WebApi -c Release -o publish')
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
