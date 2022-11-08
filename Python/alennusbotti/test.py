from selenium import webdriver
import time

#alustetaan, mikä sivu avataan
driver = webdriver.Chrome()
driver.get("https://www.verkkokauppa.com/fi/product/725093/Asus-GeForce-TUF-RTX3080-O10G-V2-GAMING-naytonohjain")


#Lisätään ostoskoriin
addcart = driver.find_element("xpath", '//*[@id="main"]/section/aside/div[2]/div[2]/div[1]/div[2]/button[1]')
addcart.click()
time.sleep(0.3)
#Siirrytään ostoskoriin
addcart = driver.find_element("xpath", '//*[@id="checkout"]')
addcart.click()



#Siirrytään täyttämään tietoja
time.sleep(0.3)
addcart = driver.find_element("xpath", '//*[@id="main"]/div[2]/div[5]/section/button')
addcart.click()
time.sleep(0.3)

#syötä sähköposti
addcart = driver.find_element("xpath", '//*[@id="login-form-email"]')
addcart.send_keys('jalopeeno@gmail.com')

#jatka, syötä salasana ja kirjaudu
addcart = driver.find_element("xpath", '//*[@id="login-button"]')
addcart = driver.find_element("xpath", '//*[@id="login-form-password"]')
addcart.send_keys('1991060-Samtron9')
addcart = driver.find_element("xpath", '//*[@id="login-button"]')
addcart.click()
time.sleep(1)
#nextnextnext




















'teksti = driver.find_element("xpath", "/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input").send_keys("Haista kakka, senkin roisto! Kek")'
