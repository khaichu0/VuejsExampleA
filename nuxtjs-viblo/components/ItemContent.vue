<template>
  <div class="item_content_item">
    <div class="item_name_block">
      <div class="item_name_logo">
        <svg
          width="32"
          height="32"
          viewBox="0 0 32 32"
          fill="none"
          xmlns="http://www.w3.org/2000/svg"
        >
          <path
            d="M23 8H9C8.20435 8 7.44129 8.31607 6.87868 8.87868C6.31607 9.44129 6 10.2044 6 11V21C6 21.7956 6.31607 22.5587 6.87868 23.1213C7.44129 23.6839 8.20435 24 9 24H23C23.7956 24 24.5587 23.6839 25.1213 23.1213C25.6839 22.5587 26 21.7956 26 21V11C26 10.2044 25.6839 9.44129 25.1213 8.87868C24.5587 8.31607 23.7956 8 23 8ZM22.59 10L16.71 15.88C16.617 15.9737 16.5064 16.0481 16.3846 16.0989C16.2627 16.1497 16.132 16.1758 16 16.1758C15.868 16.1758 15.7373 16.1497 15.6154 16.0989C15.4936 16.0481 15.383 15.9737 15.29 15.88L9.41 10H22.59ZM24 21C24 21.2652 23.8946 21.5196 23.7071 21.7071C23.5196 21.8946 23.2652 22 23 22H9C8.73478 22 8.48043 21.8946 8.29289 21.7071C8.10536 21.5196 8 21.2652 8 21V11.41L13.88 17.29C14.4425 17.8518 15.205 18.1674 16 18.1674C16.795 18.1674 17.5575 17.8518 18.12 17.29L24 11.41V21Z"
            fill="#194185"
          />
        </svg>
      </div>
      <label class="item_name">Tìm kiếm</label>
    </div>
    <item-content-function/>
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
  },
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

  border: 1px solid #53b1fd;
  border-radius: 4px;
}
.item_name_block {
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 0px;
  gap: 16px;

  width: 94px;
  height: 32px;
}
.item_name {
  width: 46px;
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
  /* identical to box height */

  /* grey / 10 */

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
</style>
