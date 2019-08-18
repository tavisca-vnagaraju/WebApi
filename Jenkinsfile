pipeline {
     agent any
    parameters{
        string(name: 'DOCKER_USERNAME', defaultValue: 'vamsi8979')
        string(name: 'DOCKER_REPO_NAME', defaultValue: 'webapi')
        string(name: 'TAG_NAME', defaultValue: 'api')
        string(name:"PORT",defaultValue:"8979")
    }
    stages {
      stage('Docker Image Pull')
      {
        steps
        {
          powershell(script:'docker pull  ${env:DOCKER_USERNAME}/${env:DOCKER_REPO_NAME}:${env:TAG_NAME}') 
        }
      }
      stage('Docker Run')
      {
        steps
        {        
          powershell(script:'docker run -p ${env:PORT}:80 ${env:DOCKER_USERNAME}/${env:DOCKER_REPO_NAME}:${env:TAG_NAME}')  
        }
      }    
    }
}