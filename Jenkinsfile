pipeline {
    agent any
    parameters{
      string(name:'PATH')
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build ${PATH} -p:configuration=release -v:n')
            }
        }
        stage('Test'){
          steps  {
                powershell(script: 'dotnet test')
          }
       }
       stage('Publish'){
          steps  {
                powershell(script: 'dotnet publish $PATH -c Release -o artifacts')
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
