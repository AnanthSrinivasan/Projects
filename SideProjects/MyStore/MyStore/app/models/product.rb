class Product < ActiveRecord::Base
  attr_accessible :category_id, :description, :name, :imageurl
  belongs_to :category 
end
