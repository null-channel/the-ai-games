# Configuration
AI Tests to test how well the AI's can assist you in writing configuration and things.

Prompt manipulation is acceptable here. The idea is to understand if the AI can help you write configuration files even if it takes propmt engineering to do so. We should probably bias the score towards the AI's that can do it without prompt engineering, and take into consideration the amount of time it takes to do the prompt engineering.

## Ideas
1. find something in CNCF that needs 3 or 4 projects configured and ask it to do that (kubeflow maybe?)
2. go to 

## Kubernetes
1. create a configuration for kubernetes and deploy it with elastic search, kibana, and fluentd
1. create a k8s nginx deployment
1. create a k8s service to expose prior deployment

## Ansible
1. create a playbook to install nginx
2. create a playbook to install docker
3. create a playbook to install kubernetes
4. create a playbook to security harden debian OS

## Terraform
1. Setup basic EKS cluster
2. Setup GKE cluster
3. Setup AKS cluster

## Nginx and haproxy
1. configure a reverse proxy

## Bad Configuration
### Test the AI's ability to detect bad configuration
1. create a configuration that will cause a kubernetes cluster to fail to start
2. create haproxy configuration that will cause haproxy to fail to start
3. create insecure nginx configuration
