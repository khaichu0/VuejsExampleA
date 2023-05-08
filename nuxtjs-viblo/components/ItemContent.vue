<template>
  <div class="item_content_item"  >
    <div class="item_name_block"  @click="navigateToItem">
      <div class="item_name_logo" >
       <img :src="item.path" alt="" class="svg">
      </div>
      <label class="item_name truncate">{{item.name}}</label>
    </div>
    <item-content-function @delete-item="deleteItem" />
  </div>
</template>
<script>
import ItemContentFunction from '~/components/ItemContentFunction.vue'

export default {
  components:{
    ItemContentFunction,
  },
  props: {
    label: String,
    item: {
      type: Object,
    },
    active:{
      type:Boolean
    },
    itemIndex:{
      type:Number
    }
  },
  watch:{

  },
  methods: {
    navigateToItem() {
      this.$emit('navigate-to-item', this.item)
    },
    deleteItem(){
      this.$emit('delete-item', this.item)

    }
  }
};
</script>
<style scoped>
@import url('https://fonts.googleapis.com/css?family=Inter');
.item_content_item {
  /* Auto layout */

  box-sizing: border-box;

  /* Auto layout */

  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  margin: 24px 24px;
  padding: 8px 16px;
  gap: 16px;

  width: 1007px;
  height: 60px;

  background: #ffffff;
  /* Blue / 06 */

  border: 2px solid #c1c4c6;

  border-radius: 4px;
}
.active{
  border: 1px solid #53b1fd;

}
.item_name_block {
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 0px;
  gap: 16px;

  width: 804px;
  height: 32px;
}
.item_name {
  width: 900px;
  height: 22px;
  clear: both;
  display: inline-block;
  white-space: nowrap;
  font-weight: bold;
  font-family: "Inter";
  font-style: normal;
  font-weight: 500;
  font-size: 18px;
  line-height: 22px;
  color: #1d2939;


}
.item_function_block {
  display: flex;
  flex-direction: row;
  align-items: flex-start;
  padding: 0px;
  gap: 8px;
  width: 148px;
  height: 44px;
}
.svg {
  filter: invert(1)
}
.truncate {

  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
</style>
